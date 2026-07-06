using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class GPUParticleSimulationPassConstructor : IPassConstructor
	{
		internal GPUParticleSimulationPassConstructor(HGRenderPathBase.HGRenderPathResources resources)
		{
			// // GPUParticleSimulationPassConstructor(HGRenderPathBase+HGRenderPathResources)
			// void HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::GPUParticleSimulationPassConstructor(
			//         GPUParticleSimulationPassConstructor *this,
			//         HGRenderPathBase_HGRenderPathResources *resources,
			//         MethodInfo *method)
			// {
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *v5; // rax
			//   OneofDescriptorProto *v6; // rdx
			//   ComputeShader *m_particleCleanupShader; // rcx
			//   DynamicArray_1_HG_Rendering_Runtime_GPUParticleSimulationPassConstructor_SimulateRequiredResources_ *v8; // rsi
			//   OneofDescriptorProto *v9; // rdx
			//   FileDescriptor *v10; // r8
			//   MessageDescriptor *v11; // r9
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *v12; // rax
			//   DynamicArray_1_HG_Rendering_Runtime_GPUParticleSimulationPassConstructor_SimulateRequiredResources_ *v13; // rsi
			//   OneofDescriptorProto *v14; // rdx
			//   FileDescriptor *v15; // r8
			//   MessageDescriptor *v16; // r9
			//   Dictionary_2_System_Guid_System_Int32_ *v17; // rax
			//   Dictionary_2_System_Guid_System_Int32_ *v18; // rsi
			//   OneofDescriptorProto *v19; // rdx
			//   FileDescriptor *v20; // r8
			//   MessageDescriptor *v21; // r9
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v22; // rax
			//   List_1_System_Int32_ *v23; // rsi
			//   OneofDescriptorProto *v24; // rdx
			//   FileDescriptor *v25; // r8
			//   MessageDescriptor *v26; // r9
			//   FileDescriptor *v27; // r8
			//   MessageDescriptor *v28; // r9
			//   HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
			//   FileDescriptor *v30; // r8
			//   MessageDescriptor *v31; // r9
			//   HGRenderPipelineRuntimeResources_ShaderResources *v32; // rax
			//   FileDescriptor *v33; // r8
			//   MessageDescriptor *v34; // r9
			//   HGRenderPipelineRuntimeResources_ShaderResources *v35; // rax
			//   FileDescriptor *v36; // r8
			//   MessageDescriptor *v37; // r9
			//   HGRenderPipelineRuntimeResources_ShaderResources *v38; // rax
			//   FileDescriptor *v39; // r8
			//   MessageDescriptor *v40; // r9
			//   HGRenderPipelineRuntimeResources_ShaderResources *v41; // rax
			//   int32_t Kernel; // eax
			//   int32_t v43; // eax
			//   int32_t v44; // eax
			//   int32_t v45; // eax
			//   int32_t v46; // eax
			//   int32_t v47; // eax
			//   int32_t v48; // eax
			//   int32_t v49; // eax
			//   ComputeShader *m_particleInitShader; // rdx
			//   __int64 v51; // xmm1_8
			//   OneofDescriptorProto *v52; // rdx
			//   FileDescriptor *v53; // r8
			//   MessageDescriptor *v54; // r9
			//   ComputeShader *v55; // rdx
			//   __int64 v56; // xmm1_8
			//   OneofDescriptorProto *v57; // rdx
			//   FileDescriptor *v58; // r8
			//   MessageDescriptor *v59; // r9
			//   LocalKeyword v60; // [rsp+20h] [rbp-38h] BYREF
			//   LocalKeyword v61; // [rsp+38h] [rbp-20h] BYREF
			// 
			//   if ( !byte_18D8EDA8D )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::Guid,int>::Dictionary);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::Dictionary<System::Guid,int>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::DynamicArray);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::List);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<int>);
			//     sub_18003C530(&off_18C8F7BB0);
			//     sub_18003C530(&off_18C95B248);
			//     sub_18003C530(&off_18C8F7BC0);
			//     sub_18003C530(&off_18C8F7BC8);
			//     sub_18003C530(&off_18C8F7BD0);
			//     sub_18003C530(&off_18C8F7BA0);
			//     sub_18003C530(&off_18C953538);
			//     byte_18D8EDA8D = 1;
			//   }
			//   v5 = (DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *)sub_180004920(TypeInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>);
			//   v8 = (DynamicArray_1_HG_Rendering_Runtime_GPUParticleSimulationPassConstructor_SimulateRequiredResources_ *)v5;
			//   if ( !v5 )
			//     goto LABEL_26;
			//   UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::DynamicArray(
			//     v5,
			//     MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::DynamicArray);
			//   this.fields.m_simulateList = v8;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields,
			//     v9,
			//     v10,
			//     v11,
			//     (String__Array *)v60.m_SpaceInfo.m_KeywordSpace,
			//     v60.m_Name,
			//     *(MethodInfo **)&v60.m_Index);
			//   v12 = (DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *)sub_180004920(TypeInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>);
			//   v13 = (DynamicArray_1_HG_Rendering_Runtime_GPUParticleSimulationPassConstructor_SimulateRequiredResources_ *)v12;
			//   if ( !v12 )
			//     goto LABEL_26;
			//   UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::DynamicArray(
			//     v12,
			//     MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::DynamicArray);
			//   this.fields.m_senderSimulateList = v13;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_senderSimulateList,
			//     v14,
			//     v15,
			//     v16,
			//     (String__Array *)v60.m_SpaceInfo.m_KeywordSpace,
			//     v60.m_Name,
			//     *(MethodInfo **)&v60.m_Index);
			//   v17 = (Dictionary_2_System_Guid_System_Int32_ *)sub_180004920(TypeInfo::System::Collections::Generic::Dictionary<System::Guid,int>);
			//   v18 = v17;
			//   if ( !v17 )
			//     goto LABEL_26;
			//   System::Collections::Generic::Dictionary<System::Guid,int>::Dictionary(
			//     v17,
			//     MethodInfo::System::Collections::Generic::Dictionary<System::Guid,int>::Dictionary);
			//   this.fields.m_gpuEventDict = v18;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_gpuEventDict,
			//     v19,
			//     v20,
			//     v21,
			//     (String__Array *)v60.m_SpaceInfo.m_KeywordSpace,
			//     v60.m_Name,
			//     *(MethodInfo **)&v60.m_Index);
			//   v22 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<int>);
			//   v23 = (List_1_System_Int32_ *)v22;
			//   if ( !v22 )
			//     goto LABEL_26;
			//   System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//     v22,
			//     MethodInfo::System::Collections::Generic::List<int>::List);
			//   this.fields.m_receivers = v23;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_receivers,
			//     v24,
			//     v25,
			//     v26,
			//     (String__Array *)v60.m_SpaceInfo.m_KeywordSpace,
			//     v60.m_Name,
			//     *(MethodInfo **)&v60.m_Index);
			//   if ( !resources.defaultResources )
			//     goto LABEL_26;
			//   shaders = resources.defaultResources.fields.shaders;
			//   if ( !shaders )
			//     goto LABEL_26;
			//   this.fields.m_particleCleanupShader = shaders.fields.particleCleanupCS;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_particleCleanupShader,
			//     v6,
			//     v27,
			//     v28,
			//     (String__Array *)v60.m_SpaceInfo.m_KeywordSpace,
			//     v60.m_Name,
			//     *(MethodInfo **)&v60.m_Index);
			//   if ( !resources.defaultResources )
			//     goto LABEL_26;
			//   v32 = resources.defaultResources.fields.shaders;
			//   if ( !v32 )
			//     goto LABEL_26;
			//   this.fields.m_particleInitShader = v32.fields.particleInitCS;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_particleInitShader,
			//     v6,
			//     v30,
			//     v31,
			//     (String__Array *)v60.m_SpaceInfo.m_KeywordSpace,
			//     v60.m_Name,
			//     *(MethodInfo **)&v60.m_Index);
			//   if ( !resources.defaultResources )
			//     goto LABEL_26;
			//   v35 = resources.defaultResources.fields.shaders;
			//   if ( !v35 )
			//     goto LABEL_26;
			//   this.fields.m_particleCullShader = v35.fields.particleCullCS;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_particleCullShader,
			//     v6,
			//     v33,
			//     v34,
			//     (String__Array *)v60.m_SpaceInfo.m_KeywordSpace,
			//     v60.m_Name,
			//     *(MethodInfo **)&v60.m_Index);
			//   if ( !resources.defaultResources )
			//     goto LABEL_26;
			//   v38 = resources.defaultResources.fields.shaders;
			//   if ( !v38 )
			//     goto LABEL_26;
			//   this.fields.m_particleSortShader = v38.fields.particleSortCS;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_particleSortShader,
			//     v6,
			//     v36,
			//     v37,
			//     (String__Array *)v60.m_SpaceInfo.m_KeywordSpace,
			//     v60.m_Name,
			//     *(MethodInfo **)&v60.m_Index);
			//   if ( !resources.defaultResources )
			//     goto LABEL_26;
			//   v41 = resources.defaultResources.fields.shaders;
			//   if ( !v41 )
			//     goto LABEL_26;
			//   this.fields.m_particleIndirectArgsShader = v41.fields.particleIndirectArgsCS;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_particleIndirectArgsShader,
			//     v6,
			//     v39,
			//     v40,
			//     (String__Array *)v60.m_SpaceInfo.m_KeywordSpace,
			//     v60.m_Name,
			//     *(MethodInfo **)&v60.m_Index);
			//   m_particleCleanupShader = this.fields.m_particleCleanupShader;
			//   if ( !m_particleCleanupShader )
			//     goto LABEL_26;
			//   Kernel = UnityEngine::ComputeShader::FindKernel(m_particleCleanupShader, (String *)"CSMain", 0LL);
			//   m_particleCleanupShader = this.fields.m_particleInitShader;
			//   this.fields.m_particleCleanupKernel = Kernel;
			//   if ( !m_particleCleanupShader )
			//     goto LABEL_26;
			//   v43 = UnityEngine::ComputeShader::FindKernel(m_particleCleanupShader, (String *)"CSMain", 0LL);
			//   m_particleCleanupShader = this.fields.m_particleCullShader;
			//   this.fields.m_particleInitKernel = v43;
			//   if ( !m_particleCleanupShader )
			//     goto LABEL_26;
			//   v44 = UnityEngine::ComputeShader::FindKernel(m_particleCleanupShader, (String *)"CSMain", 0LL);
			//   m_particleCleanupShader = this.fields.m_particleSortShader;
			//   this.fields.m_particleCullKernel = v44;
			//   if ( !m_particleCleanupShader )
			//     goto LABEL_26;
			//   v45 = UnityEngine::ComputeShader::FindKernel(m_particleCleanupShader, (String *)"Sort", 0LL);
			//   m_particleCleanupShader = this.fields.m_particleSortShader;
			//   this.fields.m_bitonicSortKernel = v45;
			//   if ( !m_particleCleanupShader )
			//     goto LABEL_26;
			//   v46 = UnityEngine::ComputeShader::FindKernel(m_particleCleanupShader, (String *)"SortFinal", 0LL);
			//   m_particleCleanupShader = this.fields.m_particleSortShader;
			//   this.fields.m_bitonicSortFinalKernel = v46;
			//   if ( !m_particleCleanupShader
			//     || (v47 = UnityEngine::ComputeShader::FindKernel(m_particleCleanupShader, (String *)"Merge", 0LL),
			//         m_particleCleanupShader = this.fields.m_particleSortShader,
			//         this.fields.m_mergeKernel = v47,
			//         !m_particleCleanupShader)
			//     || (v48 = UnityEngine::ComputeShader::FindKernel(m_particleCleanupShader, (String *)"MergeFinal", 0LL),
			//         m_particleCleanupShader = this.fields.m_particleIndirectArgsShader,
			//         this.fields.m_mergeFinalKernel = v48,
			//         !m_particleCleanupShader) )
			//   {
			// LABEL_26:
			//     sub_180B536AC(m_particleCleanupShader, v6);
			//   }
			//   v49 = UnityEngine::ComputeShader::FindKernel(m_particleCleanupShader, (String *)"CSMain", 0LL);
			//   m_particleInitShader = this.fields.m_particleInitShader;
			//   this.fields.m_particleIndirectArgsKernel = v49;
			//   memset(&v60, 0, sizeof(v60));
			//   UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v60, m_particleInitShader, (String *)"GPU_EVENT_SENDER", 0LL);
			//   v51 = *(_QWORD *)&v60.m_Index;
			//   *(_OWORD *)&this.fields.m_senderKeyword.m_SpaceInfo.m_KeywordSpace = *(_OWORD *)&v60.m_SpaceInfo.m_KeywordSpace;
			//   *(_QWORD *)&this.fields.m_senderKeyword.m_Index = v51;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_senderKeyword.m_Name,
			//     v52,
			//     v53,
			//     v54,
			//     (String__Array *)v60.m_SpaceInfo.m_KeywordSpace,
			//     v60.m_Name,
			//     *(MethodInfo **)&v60.m_Index);
			//   v55 = this.fields.m_particleInitShader;
			//   memset(&v61, 0, sizeof(v61));
			//   UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v61, v55, (String *)"GPU_EVENT_RECIEVER", 0LL);
			//   v56 = *(_QWORD *)&v61.m_Index;
			//   *(_OWORD *)&this.fields.m_recieverKeyword.m_SpaceInfo.m_KeywordSpace = *(_OWORD *)&v61.m_SpaceInfo.m_KeywordSpace;
			//   *(_QWORD *)&this.fields.m_recieverKeyword.m_Index = v56;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_recieverKeyword.m_Name,
			//     v57,
			//     v58,
			//     v59,
			//     (String__Array *)v60.m_SpaceInfo.m_KeywordSpace,
			//     v60.m_Name,
			//     *(MethodInfo **)&v60.m_Index);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         GPUParticleSimulationPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2675, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2675, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_340(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         GPUParticleSimulationPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2676, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2676, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		private static void ProcessParticles(DynamicArray<GPUParticleSimulationPassConstructor.SimulateRequiredResources> sysList, GPUParticleSimulationPassConstructor.PassData data, HGRenderGraphContext context)
		{
			// // Void ProcessParticles(DynamicArray`1[HG.Rendering.Runtime.GPUParticleSimulationPassConstructor+SimulateRequiredResources], GPUParticleSimulationPassConstructor+PassData, HGRenderGraphContext)
			// void HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::ProcessParticles(
			//         DynamicArray_1_HG_Rendering_Runtime_GPUParticleSimulationPassConstructor_SimulateRequiredResources_ *sysList,
			//         GPUParticleSimulationPassConstructor_PassData *data,
			//         HGRenderGraphContext *context,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   _DWORD *p_CB0; // rcx
			//   CommandBuffer *cmd; // r15
			//   int32_t Ticks; // eax
			//   signed int seed; // esi
			//   __int64 v12; // rax
			//   bool v13; // zf
			//   __m128i v14; // xmm11
			//   __m128i v15; // xmm6
			//   __m128i v16; // xmm8
			//   __m128i v17; // xmm10
			//   __m128i v18; // xmm9
			//   unsigned int i; // ebx
			//   ComputeShader *particleCleanupShader; // r14
			//   int32_t size; // eax
			//   float v22; // xmm0_4
			//   GPUParticleSimulationPassConstructor_SimulateRequiredResources *Item; // rbx
			//   GPUParticleSimulationPassConstructor_SimulateRequiredResources *v24; // rax
			//   GPUParticleSimulationPassConstructor_SimulateRequiredResources *v25; // rax
			//   bool v26; // al
			//   int32_t particleInitKernel; // edi
			//   ComputeShader *particleInitShader; // r14
			//   LocalKeyword *p_senderKeyword; // r8
			//   int32_t GPUEventConsumedCount; // edi
			//   ComputeBufferHandle comsumedCountBuffer; // rbx
			//   ComputeBuffer *v32; // rax
			//   int32_t v33; // r9d
			//   int32_t stride; // eax
			//   ComputeBufferHandle dataForEmitterBuffer; // rbx
			//   int32_t DataForEmitter; // edi
			//   ComputeBuffer *v37; // rax
			//   ComputeBuffer *v38; // rax
			//   int32_t v39; // eax
			//   int32_t v40; // ebx
			//   int32_t count; // eax
			//   int32_t v42; // ebx
			//   int32_t v43; // eax
			//   int32_t v44; // ebx
			//   ComputeBuffer *v45; // rax
			//   GPUParticleSimulationPassConstructor_SimulateRequiredResources *v46; // rbx
			//   int32_t shaderID; // ebx
			//   TextureHandle texture; // xmm6
			//   RenderTargetIdentifier *v49; // rax
			//   __int128 v50; // xmm1
			//   __int64 v51; // xmm0_8
			//   GPUParticleSimulationPassConstructor_SimulateRequiredResources *v52; // rbx
			//   int32_t v53; // ebx
			//   TextureHandle v54; // xmm6
			//   RenderTargetIdentifier *v55; // rax
			//   __int128 v56; // xmm1
			//   __int64 v57; // xmm0_8
			//   GPUParticleSimulationPassConstructor_SimulateRequiredResources *v58; // rbx
			//   int32_t v59; // ebx
			//   TextureHandle v60; // xmm6
			//   RenderTargetIdentifier *v61; // rax
			//   __int128 v62; // xmm1
			//   __int64 v63; // xmm0_8
			//   int32_t GPUEventBuffer; // edi
			//   ComputeBufferHandle eventBuffer; // rbx
			//   ComputeBuffer *v66; // rax
			//   int32_t v67; // edi
			//   ComputeBufferHandle v68; // rbx
			//   ComputeBuffer *v69; // rax
			//   int32_t PerFrameVariables; // ebx
			//   ComputeShader *v71; // xmm11_8
			//   int32_t GeneralGPUParticleSystemAttributes; // ebx
			//   int32_t v73; // eax
			//   int32_t GPUParticleSystemAttributes; // edi
			//   int32_t v75; // ebx
			//   int32_t v76; // eax
			//   GPUParticleSimulationPassConstructor_SimulateRequiredResources *v77; // rbx
			//   int32_t v78; // ebx
			//   TextureHandle v79; // xmm6
			//   RenderTargetIdentifier *v80; // rax
			//   __int128 v81; // xmm1
			//   __int64 v82; // xmm0_8
			//   GPUParticleSimulationPassConstructor_SimulateRequiredResources *v83; // rbx
			//   int32_t v84; // ebx
			//   TextureHandle v85; // xmm6
			//   RenderTargetIdentifier *v86; // rax
			//   __int128 v87; // xmm1
			//   __int64 v88; // xmm0_8
			//   GPUParticleSimulationPassConstructor_SimulateRequiredResources *v89; // rbx
			//   int32_t v90; // ebx
			//   TextureHandle v91; // xmm6
			//   RenderTargetIdentifier *v92; // rax
			//   __int128 v93; // xmm1
			//   __int64 v94; // xmm0_8
			//   int32_t v95; // edi
			//   ComputeBufferHandle v96; // rbx
			//   ComputeBuffer *v97; // rax
			//   int32_t GPUEventSentCount; // edi
			//   ComputeBufferHandle sentCountBuffer; // rbx
			//   ComputeBuffer *v100; // rax
			//   ComputeShader *particleCullShader; // rsi
			//   int32_t particleCullKernel; // r14d
			//   int32_t v103; // ebx
			//   int32_t v104; // ebx
			//   int32_t v105; // eax
			//   int32_t v106; // edi
			//   int32_t v107; // ebx
			//   int32_t v108; // eax
			//   int32_t LiveList; // ebx
			//   ComputeBuffer *v110; // rax
			//   int32_t LiveCount; // ebx
			//   ComputeBuffer *v112; // rax
			//   ComputeShader *particleSortShader; // r14
			//   ComputeBuffer *v114; // rax
			//   int32_t bitonicSortFinalKernel; // edi
			//   ComputeBuffer *v116; // rbx
			//   ComputeBuffer *v117; // rax
			//   int32_t v118; // ebx
			//   ComputeBuffer *v119; // rax
			//   unsigned int v120; // r14d
			//   unsigned int v121; // edi
			//   int v122; // ecx
			//   ComputeShader *v123; // rsi
			//   int32_t MergePassConstants; // ebx
			//   int32_t InputLiveList; // ebx
			//   ComputeBuffer *v126; // rax
			//   ComputeBuffer *v127; // rax
			//   int32_t v128; // ebx
			//   ComputeBuffer *v129; // rax
			//   ComputeShader *v130; // rsi
			//   float v131; // xmm0_4
			//   int32_t v132; // ebx
			//   int32_t v133; // ebx
			//   ComputeBuffer *v134; // rax
			//   int32_t v135; // ebx
			//   ComputeBuffer *v136; // rax
			//   ComputeShader *particleIndirectArgsShader; // r14
			//   int32_t particleIndirectArgsKernel; // esi
			//   ComputeBufferHandle liveCountBuffer; // rbx
			//   int32_t v140; // edi
			//   ComputeBuffer *v141; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   bool IsValid; // [rsp+48h] [rbp-C0h]
			//   int32_t threadGroupsX; // [rsp+4Ch] [rbp-BCh]
			//   int threadGroupsXa; // [rsp+4Ch] [rbp-BCh]
			//   int threadGroupsXb; // [rsp+4Ch] [rbp-BCh]
			//   int threadGroupsXc; // [rsp+4Ch] [rbp-BCh]
			//   unsigned int threadGroupsXd; // [rsp+4Ch] [rbp-BCh]
			//   int32_t val; // [rsp+50h] [rbp-B8h]
			//   int32_t vala; // [rsp+50h] [rbp-B8h]
			//   int32_t valb; // [rsp+50h] [rbp-B8h]
			//   int32_t valc; // [rsp+50h] [rbp-B8h]
			//   int vald; // [rsp+50h] [rbp-B8h]
			//   int32_t vale; // [rsp+50h] [rbp-B8h]
			//   int32_t valf; // [rsp+50h] [rbp-B8h]
			//   int32_t kernelIndex; // [rsp+54h] [rbp-B4h]
			//   int kernelIndexa; // [rsp+54h] [rbp-B4h]
			//   int32_t kernelIndexb; // [rsp+54h] [rbp-B4h]
			//   bool nameID; // [rsp+58h] [rbp-B0h]
			//   bool nameID_1; // [rsp+59h] [rbp-AFh]
			//   int32_t nameID_4; // [rsp+5Ch] [rbp-ACh]
			//   int nameID_4a; // [rsp+5Ch] [rbp-ACh]
			//   int32_t nameID_4b; // [rsp+5Ch] [rbp-ACh]
			//   ComputeBuffer *buffer; // [rsp+60h] [rbp-A8h]
			//   int32_t buffera; // [rsp+60h] [rbp-A8h]
			//   int32_t bufferb; // [rsp+60h] [rbp-A8h]
			//   DateTime v167; // [rsp+68h] [rbp-A0h] BYREF
			//   GPUParticleSimulationPassConstructor_PerFrameBuffer dataa[2]; // [rsp+70h] [rbp-98h] BYREF
			//   ComputeBuffer *v169; // [rsp+78h] [rbp-90h]
			//   ComputeBuffer *v170; // [rsp+80h] [rbp-88h]
			//   uint64_t v171; // [rsp+88h] [rbp-80h]
			//   TextureHandle v172; // [rsp+98h] [rbp-70h] BYREF
			//   RenderTargetIdentifier v173; // [rsp+A8h] [rbp-60h] BYREF
			//   ComputeBufferHandle v174; // [rsp+D8h] [rbp-30h] BYREF
			//   ComputeBufferHandle v175; // [rsp+E0h] [rbp-28h] BYREF
			//   ComputeBufferHandle v176; // [rsp+E8h] [rbp-20h] BYREF
			//   ComputeBufferHandle v177; // [rsp+F0h] [rbp-18h] BYREF
			//   ComputeBufferHandle v178; // [rsp+F8h] [rbp-10h] BYREF
			//   ComputeBufferHandle v179; // [rsp+100h] [rbp-8h] BYREF
			//   __m128i v180; // [rsp+168h] [rbp+60h]
			//   RenderTargetIdentifier v181[2]; // [rsp+178h] [rbp+70h] BYREF
			//   ComputeBuffer *v182[2]; // [rsp+1D8h] [rbp+D0h]
			//   __int128 v183; // [rsp+1F8h] [rbp+F0h]
			//   _BYTE v184[208]; // [rsp+218h] [rbp+110h] BYREF
			// 
			//   if ( !byte_18D91956D )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ConstantBuffer::Push<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::MergePassConstants>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ConstantBuffer::Set<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::PerFrameBuffer>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ConstantBuffer::UpdateData<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::PerFrameBuffer>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ConstantBuffer);
			//     sub_18003C530(&TypeInfo::System::DateTime);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_size);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::System::Math);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D91956D = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2677, 0LL) )
			//   {
			//     if ( !context )
			//       goto LABEL_67;
			//     cmd = context.fields.cmd;
			//     sub_180002C70(TypeInfo::System::DateTime);
			//     v167._dateData = System::DateTime::get_Now(0LL)._dateData;
			//     Ticks = System::DateTime::get_Ticks(&v167, 0LL);
			//     UnityEngine::Random::InitState(Ticks, 0LL);
			//     dataa[0].seed = UnityEngine::Random::RandomRangeInt(0x80000000, 0x7FFFFFFF, 0LL);
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::ConstantBuffer);
			//     UnityEngine::Rendering::ConstantBuffer::UpdateData<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::PerFrameBuffer>(
			//       cmd,
			//       dataa,
			//       MethodInfo::UnityEngine::Rendering::ConstantBuffer::UpdateData<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::PerFrameBuffer>);
			//     seed = 0;
			//     dataa[0].seed = 0;
			//     if ( !sysList )
			//       goto LABEL_67;
			//     while ( 1 )
			//     {
			//       if ( seed >= sysList.fields._size_k__BackingField )
			//         return;
			//       if ( !UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//               sysList,
			//               seed,
			//               MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item).gpuParticleSystem )
			//         goto LABEL_67;
			//       v12 = sub_1808308D0(v184);
			//       v13 = *(_DWORD *)(v12 + 96) == 0;
			//       v14 = *(__m128i *)v12;
			//       v15 = *(__m128i *)(v12 + 16);
			//       v16 = *(__m128i *)(v12 + 32);
			//       v17 = *(__m128i *)(v12 + 64);
			//       v18 = *(__m128i *)(v12 + 96);
			//       *(_OWORD *)v182 = *(_OWORD *)(v12 + 48);
			//       v183 = *(_OWORD *)(v12 + 80);
			//       if ( !v13 )
			//       {
			//         v13 = *(_QWORD *)(v12 + 104) == 0LL;
			//         v167._dateData = _mm_srli_si128(v16, 8).m128i_u64[0];
			//         buffer = (ComputeBuffer *)_mm_srli_si128(v15, 8).m128i_u64[0];
			//         v170 = (ComputeBuffer *)v17.m128i_i64[0];
			//         if ( !v13 )
			//         {
			//           v180 = v18;
			//           for ( i = 0; v18.m128i_i64[1]; ++i )
			//           {
			//             if ( (signed int)i >= *(_DWORD *)(v18.m128i_i64[1] + 24) )
			//               goto LABEL_18;
			//             if ( i >= *(_DWORD *)(v18.m128i_i64[1] + 24) )
			//               sub_180070270(p_CB0, v7);
			//             val = *(_DWORD *)(v18.m128i_i64[1] + 4LL * (int)i + 32);
			//             if ( !data )
			//               break;
			//             particleCleanupShader = data.fields.particleCleanupShader;
			//             kernelIndex = data.fields.particleCleanupKernel;
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//             p_CB0 = &TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._CB0;
			//             nameID_4 = p_CB0[199];
			//             if ( !buffer )
			//               break;
			//             size = UnityEngine::ComputeBuffer::get_stride(buffer, 0LL);
			//             if ( !cmd )
			//               break;
			//             UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantComputeBufferParam(
			//               cmd,
			//               particleCleanupShader,
			//               nameID_4,
			//               buffer,
			//               0,
			//               size,
			//               0LL);
			//             UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//               cmd,
			//               particleCleanupShader,
			//               kernelIndex,
			//               TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._ParticleAttributes,
			//               (ComputeBuffer *)v167._dateData,
			//               0,
			//               -1,
			//               0LL);
			//             UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//               cmd,
			//               particleCleanupShader,
			//               kernelIndex,
			//               TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._DeadList,
			//               v182[1],
			//               0,
			//               -1,
			//               0LL);
			//             UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//               cmd,
			//               particleCleanupShader,
			//               kernelIndex,
			//               TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._DeadCount,
			//               v170,
			//               0,
			//               -1,
			//               0LL);
			//             UnityEngine::Rendering::CommandBuffer::SetComputeIntParam(
			//               cmd,
			//               particleCleanupShader,
			//               TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._CleanupOffset,
			//               val,
			//               0LL);
			//             v22 = sub_1801C2670();
			//             UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
			//               cmd,
			//               particleCleanupShader,
			//               kernelIndex,
			//               (int)v22,
			//               1,
			//               1,
			//               0LL);
			//           }
			// LABEL_67:
			//           sub_180B536AC(p_CB0, v7);
			//         }
			// LABEL_18:
			//         kernelIndexa = _mm_cvtsi128_si32(v18);
			//         nameID_4a = v183 * kernelIndexa;
			//         Item = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                  sysList,
			//                  seed,
			//                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item);
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			//         IsValid = HG::Rendering::RenderGraphModule::ComputeBufferHandle::IsValid(&Item.gpuEventData.eventBuffer, 0LL);
			//         v24 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                 sysList,
			//                 seed,
			//                 MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item);
			//         nameID_1 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::IsValid(
			//                      &v24.gpuEventData.sentCountBuffer,
			//                      0LL);
			//         v25 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                 sysList,
			//                 seed,
			//                 MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item);
			//         v26 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::IsValid(
			//                 &v25.gpuEventData.comsumedCountBuffer,
			//                 0LL);
			//         nameID = v26;
			//         if ( !data )
			//           goto LABEL_67;
			//         particleInitKernel = data.fields.particleInitKernel;
			//         p_CB0 = 0LL;
			//         particleInitShader = data.fields.particleInitShader;
			//         threadGroupsX = particleInitKernel;
			//         if ( !cmd )
			//           goto LABEL_67;
			//         p_senderKeyword = &data.fields.senderKeyword;
			//         if ( IsValid )
			//         {
			//           if ( v26 )
			//           {
			//             UnityEngine::Rendering::CommandBuffer::SetKeyword(cmd, particleInitShader, p_senderKeyword, 0, 0LL);
			//             UnityEngine::Rendering::CommandBuffer::SetKeyword(
			//               cmd,
			//               particleInitShader,
			//               &data.fields.recieverKeyword,
			//               1,
			//               0LL);
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//             GPUEventConsumedCount = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._GPUEventConsumedCount;
			//             comsumedCountBuffer = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                                     sysList,
			//                                     seed,
			//                                     MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item).gpuEventData.comsumedCountBuffer;
			//           }
			//           else
			//           {
			//             UnityEngine::Rendering::CommandBuffer::SetKeyword(cmd, particleInitShader, p_senderKeyword, 1, 0LL);
			//             UnityEngine::Rendering::CommandBuffer::SetKeyword(
			//               cmd,
			//               particleInitShader,
			//               &data.fields.recieverKeyword,
			//               0,
			//               0LL);
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//             GPUEventConsumedCount = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._GPUEventSentCount;
			//             comsumedCountBuffer = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                                     sysList,
			//                                     seed,
			//                                     MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item).gpuEventData.sentCountBuffer;
			//           }
			//           sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			//           v32 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(comsumedCountBuffer, 0LL);
			//           v33 = GPUEventConsumedCount;
			//           particleInitKernel = threadGroupsX;
			//           UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//             cmd,
			//             particleInitShader,
			//             threadGroupsX,
			//             v33,
			//             v32,
			//             0,
			//             -1,
			//             0LL);
			//         }
			//         else
			//         {
			//           UnityEngine::Rendering::CommandBuffer::SetKeyword(cmd, particleInitShader, p_senderKeyword, 0, 0LL);
			//           UnityEngine::Rendering::CommandBuffer::SetKeyword(
			//             cmd,
			//             particleInitShader,
			//             &data.fields.recieverKeyword,
			//             0,
			//             0LL);
			//           IsValid = 0;
			//         }
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         p_CB0 = &TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._CB0;
			//         vala = p_CB0[199];
			//         if ( !buffer )
			//           goto LABEL_67;
			//         stride = UnityEngine::ComputeBuffer::get_stride(buffer, 0LL);
			//         UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantComputeBufferParam(
			//           cmd,
			//           particleInitShader,
			//           vala,
			//           buffer,
			//           0,
			//           stride,
			//           0LL);
			//         UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//           cmd,
			//           particleInitShader,
			//           particleInitKernel,
			//           TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._DeadCount,
			//           v170,
			//           0,
			//           -1,
			//           0LL);
			//         dataForEmitterBuffer = data.fields.dataForEmitterBuffer;
			//         DataForEmitter = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._DataForEmitter;
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			//         v37 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(dataForEmitterBuffer, 0LL);
			//         UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//           cmd,
			//           particleInitShader,
			//           threadGroupsX,
			//           DataForEmitter,
			//           v37,
			//           0,
			//           -1,
			//           0LL);
			//         dataForEmitterBuffer.handle.m_Value = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._LiveCount;
			//         v38 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(data.fields.liveCountBuffer, 0LL);
			//         UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//           cmd,
			//           particleInitShader,
			//           threadGroupsX,
			//           dataForEmitterBuffer.handle.m_Value,
			//           v38,
			//           0,
			//           -1,
			//           0LL);
			//         UnityEngine::Rendering::CommandBuffer::SetComputeIntParam(
			//           cmd,
			//           particleInitShader,
			//           TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._InstanceCount,
			//           kernelIndexa,
			//           0LL);
			//         UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
			//           cmd,
			//           particleInitShader,
			//           threadGroupsX,
			//           1,
			//           1,
			//           1,
			//           0LL);
			//         sub_180002C70(TypeInfo::System::Math);
			//         threadGroupsXa = (int)sub_1801C2670();
			//         dataForEmitterBuffer.handle.m_Value = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._PerFrameVariables;
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::ConstantBuffer);
			//         UnityEngine::Rendering::ConstantBuffer::Set<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::PerFrameBuffer>(
			//           cmd,
			//           (ComputeShader *)v14.m128i_i64[0],
			//           dataForEmitterBuffer.handle.m_Value,
			//           MethodInfo::UnityEngine::Rendering::ConstantBuffer::Set<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::PerFrameBuffer>);
			//         dataForEmitterBuffer.handle.m_Value = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._GeneralGPUParticleSystemAttributes;
			//         v39 = UnityEngine::ComputeBuffer::get_stride(buffer, 0LL);
			//         UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantComputeBufferParam(
			//           cmd,
			//           (ComputeShader *)v14.m128i_i64[0],
			//           dataForEmitterBuffer.handle.m_Value,
			//           buffer,
			//           0,
			//           v39,
			//           0LL);
			//         v169 = (ComputeBuffer *)v16.m128i_i64[0];
			//         p_CB0 = &TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._CB0;
			//         valb = p_CB0[200];
			//         if ( !v16.m128i_i64[0] )
			//           goto LABEL_67;
			//         v40 = UnityEngine::ComputeBuffer::get_stride((ComputeBuffer *)v16.m128i_i64[0], 0LL);
			//         count = UnityEngine::ComputeBuffer::get_count((ComputeBuffer *)v16.m128i_i64[0], 0LL);
			//         UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantComputeBufferParam(
			//           cmd,
			//           (ComputeShader *)v14.m128i_i64[0],
			//           valb,
			//           (ComputeBuffer *)v16.m128i_i64[0],
			//           0,
			//           v40 * count,
			//           0LL);
			//         p_CB0 = &TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._CB0;
			//         valc = p_CB0[202];
			//         if ( !v15.m128i_i64[0] )
			//           goto LABEL_67;
			//         v42 = UnityEngine::ComputeBuffer::get_stride((ComputeBuffer *)v15.m128i_i64[0], 0LL);
			//         v43 = UnityEngine::ComputeBuffer::get_count((ComputeBuffer *)v15.m128i_i64[0], 0LL);
			//         UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantComputeBufferParam(
			//           cmd,
			//           (ComputeShader *)v14.m128i_i64[0],
			//           valc,
			//           (ComputeBuffer *)v15.m128i_i64[0],
			//           0,
			//           v42 * v43,
			//           0LL);
			//         UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//           cmd,
			//           (ComputeShader *)v14.m128i_i64[0],
			//           0,
			//           TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._ParticleAttributes,
			//           (ComputeBuffer *)v167._dateData,
			//           0,
			//           -1,
			//           0LL);
			//         UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//           cmd,
			//           (ComputeShader *)v14.m128i_i64[0],
			//           0,
			//           TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._DeadList,
			//           v182[1],
			//           0,
			//           -1,
			//           0LL);
			//         UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//           cmd,
			//           (ComputeShader *)v14.m128i_i64[0],
			//           0,
			//           TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._DeadCount,
			//           v170,
			//           0,
			//           -1,
			//           0LL);
			//         v44 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._DataForEmitter;
			//         v45 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(data.fields.dataForEmitterBuffer, 0LL);
			//         UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//           cmd,
			//           (ComputeShader *)v14.m128i_i64[0],
			//           0,
			//           v44,
			//           v45,
			//           0,
			//           -1,
			//           0LL);
			//         UnityEngine::Rendering::CommandBuffer::SetComputeIntParam(
			//           cmd,
			//           (ComputeShader *)v14.m128i_i64[0],
			//           TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._DispatchSize,
			//           threadGroupsXa << 6,
			//           0LL);
			//         v46 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                 sysList,
			//                 seed,
			//                 MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item);
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v46.depthOnlyRT.texture, 0LL) )
			//         {
			//           shaderID = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                        sysList,
			//                        seed,
			//                        MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item).depthOnlyRT.shaderID;
			//           texture = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                       sysList,
			//                       seed,
			//                       MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item).depthOnlyRT.texture;
			//           sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//           v172 = texture;
			//           v49 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(v181, &v172, 0LL);
			//           v50 = *(_OWORD *)&v49.m_BufferPointer;
			//           *(_OWORD *)&v173.m_Type = *(_OWORD *)&v49.m_Type;
			//           v51 = *(_QWORD *)&v49.m_DepthSlice;
			//           *(_OWORD *)&v173.m_BufferPointer = v50;
			//           *(_QWORD *)&v173.m_DepthSlice = v51;
			//           UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
			//             cmd,
			//             (ComputeShader *)v14.m128i_i64[0],
			//             0,
			//             shaderID,
			//             &v173,
			//             0LL);
			//         }
			//         v52 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                 sysList,
			//                 seed,
			//                 MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item);
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v52.sceneNormal.texture, 0LL) )
			//         {
			//           v53 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                   sysList,
			//                   seed,
			//                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item).sceneNormal.shaderID;
			//           v54 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                   sysList,
			//                   seed,
			//                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item).sceneNormal.texture;
			//           sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//           v172 = v54;
			//           v55 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(v181, &v172, 0LL);
			//           v56 = *(_OWORD *)&v55.m_BufferPointer;
			//           *(_OWORD *)&v173.m_Type = *(_OWORD *)&v55.m_Type;
			//           v57 = *(_QWORD *)&v55.m_DepthSlice;
			//           *(_OWORD *)&v173.m_BufferPointer = v56;
			//           *(_QWORD *)&v173.m_DepthSlice = v57;
			//           UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
			//             cmd,
			//             (ComputeShader *)v14.m128i_i64[0],
			//             0,
			//             v53,
			//             &v173,
			//             0LL);
			//         }
			//         v58 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                 sysList,
			//                 seed,
			//                 MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item);
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v58.sceneDepth.texture, 0LL) )
			//         {
			//           v59 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                   sysList,
			//                   seed,
			//                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item).sceneDepth.shaderID;
			//           v60 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                   sysList,
			//                   seed,
			//                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item).sceneDepth.texture;
			//           sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//           v172 = v60;
			//           v61 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(v181, &v172, 0LL);
			//           v62 = *(_OWORD *)&v61.m_BufferPointer;
			//           *(_OWORD *)&v173.m_Type = *(_OWORD *)&v61.m_Type;
			//           v63 = *(_QWORD *)&v61.m_DepthSlice;
			//           *(_OWORD *)&v173.m_BufferPointer = v62;
			//           *(_QWORD *)&v173.m_DepthSlice = v63;
			//           UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
			//             cmd,
			//             (ComputeShader *)v14.m128i_i64[0],
			//             0,
			//             v59,
			//             &v173,
			//             0LL);
			//         }
			//         if ( IsValid )
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//           GPUEventBuffer = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._GPUEventBuffer;
			//           eventBuffer = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                           sysList,
			//                           seed,
			//                           MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item).gpuEventData.eventBuffer;
			//           sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			//           v66 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(eventBuffer, 0LL);
			//           UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//             cmd,
			//             (ComputeShader *)v14.m128i_i64[0],
			//             0,
			//             GPUEventBuffer,
			//             v66,
			//             0,
			//             -1,
			//             0LL);
			//         }
			//         if ( nameID )
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//           v67 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._GPUEventConsumedCount;
			//           v68 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                   sysList,
			//                   seed,
			//                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item).gpuEventData.comsumedCountBuffer;
			//           sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			//           v69 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(v68, 0LL);
			//           UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//             cmd,
			//             (ComputeShader *)v14.m128i_i64[0],
			//             0,
			//             v67,
			//             v69,
			//             0,
			//             -1,
			//             0LL);
			//         }
			//         UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
			//           cmd,
			//           (ComputeShader *)v14.m128i_i64[0],
			//           0,
			//           threadGroupsXa,
			//           1,
			//           kernelIndexa,
			//           0LL);
			//         threadGroupsXb = (int)sub_1801C2670();
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         PerFrameVariables = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._PerFrameVariables;
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::ConstantBuffer);
			//         v71 = (ComputeShader *)_mm_srli_si128(v14, 8).m128i_u64[0];
			//         UnityEngine::Rendering::ConstantBuffer::Set<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::PerFrameBuffer>(
			//           cmd,
			//           v71,
			//           PerFrameVariables,
			//           MethodInfo::UnityEngine::Rendering::ConstantBuffer::Set<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::PerFrameBuffer>);
			//         GeneralGPUParticleSystemAttributes = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._GeneralGPUParticleSystemAttributes;
			//         v73 = UnityEngine::ComputeBuffer::get_stride(buffer, 0LL);
			//         UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantComputeBufferParam(
			//           cmd,
			//           v71,
			//           GeneralGPUParticleSystemAttributes,
			//           buffer,
			//           0,
			//           v73,
			//           0LL);
			//         GPUParticleSystemAttributes = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._GPUParticleSystemAttributes;
			//         v75 = UnityEngine::ComputeBuffer::get_stride(v169, 0LL);
			//         v76 = UnityEngine::ComputeBuffer::get_count(v169, 0LL);
			//         UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantComputeBufferParam(
			//           cmd,
			//           v71,
			//           GPUParticleSystemAttributes,
			//           v169,
			//           0,
			//           v75 * v76,
			//           0LL);
			//         UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//           cmd,
			//           v71,
			//           0,
			//           TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._ParticleAttributes,
			//           (ComputeBuffer *)v167._dateData,
			//           0,
			//           -1,
			//           0LL);
			//         UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//           cmd,
			//           v71,
			//           0,
			//           TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._DeadList,
			//           v182[1],
			//           0,
			//           -1,
			//           0LL);
			//         UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//           cmd,
			//           v71,
			//           0,
			//           TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._DeadCount,
			//           v170,
			//           0,
			//           -1,
			//           0LL);
			//         UnityEngine::Rendering::CommandBuffer::SetComputeIntParam(
			//           cmd,
			//           v71,
			//           TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._DispatchSize,
			//           threadGroupsXb << 6,
			//           0LL);
			//         v77 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                 sysList,
			//                 seed,
			//                 MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item);
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v77.depthOnlyRT.texture, 0LL) )
			//         {
			//           v78 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                   sysList,
			//                   seed,
			//                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item).depthOnlyRT.shaderID;
			//           v79 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                   sysList,
			//                   seed,
			//                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item).depthOnlyRT.texture;
			//           sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//           v172 = v79;
			//           v80 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(v181, &v172, 0LL);
			//           v81 = *(_OWORD *)&v80.m_BufferPointer;
			//           *(_OWORD *)&v173.m_Type = *(_OWORD *)&v80.m_Type;
			//           v82 = *(_QWORD *)&v80.m_DepthSlice;
			//           *(_OWORD *)&v173.m_BufferPointer = v81;
			//           *(_QWORD *)&v173.m_DepthSlice = v82;
			//           UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(cmd, v71, 0, v78, &v173, 0LL);
			//         }
			//         v83 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                 sysList,
			//                 seed,
			//                 MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item);
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v83.sceneNormal.texture, 0LL) )
			//         {
			//           v84 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                   sysList,
			//                   seed,
			//                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item).sceneNormal.shaderID;
			//           v85 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                   sysList,
			//                   seed,
			//                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item).sceneNormal.texture;
			//           sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//           v172 = v85;
			//           v86 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(v181, &v172, 0LL);
			//           v87 = *(_OWORD *)&v86.m_BufferPointer;
			//           *(_OWORD *)&v173.m_Type = *(_OWORD *)&v86.m_Type;
			//           v88 = *(_QWORD *)&v86.m_DepthSlice;
			//           *(_OWORD *)&v173.m_BufferPointer = v87;
			//           *(_QWORD *)&v173.m_DepthSlice = v88;
			//           UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(cmd, v71, 0, v84, &v173, 0LL);
			//         }
			//         v89 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                 sysList,
			//                 seed,
			//                 MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item);
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v89.sceneDepth.texture, 0LL) )
			//         {
			//           v90 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                   sysList,
			//                   seed,
			//                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item).sceneDepth.shaderID;
			//           v91 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                   sysList,
			//                   seed,
			//                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item).sceneDepth.texture;
			//           sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//           v172 = v91;
			//           v92 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(v181, &v172, 0LL);
			//           v93 = *(_OWORD *)&v92.m_BufferPointer;
			//           *(_OWORD *)&v173.m_Type = *(_OWORD *)&v92.m_Type;
			//           v94 = *(_QWORD *)&v92.m_DepthSlice;
			//           *(_OWORD *)&v173.m_BufferPointer = v93;
			//           *(_QWORD *)&v173.m_DepthSlice = v94;
			//           UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(cmd, v71, 0, v90, &v173, 0LL);
			//         }
			//         if ( IsValid )
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//           v95 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._GPUEventBuffer;
			//           v96 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                   sysList,
			//                   seed,
			//                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item).gpuEventData.eventBuffer;
			//           sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			//           v97 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(v96, 0LL);
			//           UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(cmd, v71, 0, v95, v97, 0, -1, 0LL);
			//         }
			//         if ( nameID_1 )
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//           GPUEventSentCount = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._GPUEventSentCount;
			//           sentCountBuffer = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                               sysList,
			//                               seed,
			//                               MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item).gpuEventData.sentCountBuffer;
			//           sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			//           v100 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(sentCountBuffer, 0LL);
			//           UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//             cmd,
			//             v71,
			//             0,
			//             GPUEventSentCount,
			//             v100,
			//             0,
			//             -1,
			//             0LL);
			//         }
			//         UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
			//           cmd,
			//           v71,
			//           0,
			//           threadGroupsXb,
			//           1,
			//           kernelIndexa,
			//           0LL);
			//         particleCullShader = data.fields.particleCullShader;
			//         particleCullKernel = data.fields.particleCullKernel;
			//         vald = (int)sub_1801C2670();
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         v103 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._PerFrameVariables;
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::ConstantBuffer);
			//         UnityEngine::Rendering::ConstantBuffer::Set<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::PerFrameBuffer>(
			//           cmd,
			//           particleCullShader,
			//           v103,
			//           MethodInfo::UnityEngine::Rendering::ConstantBuffer::Set<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::PerFrameBuffer>);
			//         v104 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._GeneralGPUParticleSystemAttributes;
			//         v105 = UnityEngine::ComputeBuffer::get_stride(buffer, 0LL);
			//         UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantComputeBufferParam(
			//           cmd,
			//           particleCullShader,
			//           v104,
			//           buffer,
			//           0,
			//           v105,
			//           0LL);
			//         v106 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._GPUParticleSystemAttributes;
			//         v107 = UnityEngine::ComputeBuffer::get_stride(v169, 0LL);
			//         v108 = UnityEngine::ComputeBuffer::get_count(v169, 0LL);
			//         UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantComputeBufferParam(
			//           cmd,
			//           particleCullShader,
			//           v106,
			//           v169,
			//           0,
			//           v107 * v108,
			//           0LL);
			//         UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//           cmd,
			//           particleCullShader,
			//           particleCullKernel,
			//           TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._ParticleAttributes,
			//           (ComputeBuffer *)v167._dateData,
			//           0,
			//           -1,
			//           0LL);
			//         LiveList = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._LiveList;
			//         p_CB0 = data.fields.stagingLiveListBuffers;
			//         if ( !p_CB0 )
			//           goto LABEL_67;
			//         sub_18041FE6C(p_CB0, &v174, 0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			//         v110 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(v174, 0LL);
			//         UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//           cmd,
			//           particleCullShader,
			//           particleCullKernel,
			//           LiveList,
			//           v110,
			//           0,
			//           -1,
			//           0LL);
			//         LiveCount = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._LiveCount;
			//         v112 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(data.fields.liveCountBuffer, 0LL);
			//         UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//           cmd,
			//           particleCullShader,
			//           particleCullKernel,
			//           LiveCount,
			//           v112,
			//           0,
			//           -1,
			//           0LL);
			//         UnityEngine::Rendering::CommandBuffer::SetComputeIntParam(
			//           cmd,
			//           particleCullShader,
			//           TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._DispatchSize,
			//           vald << 6,
			//           0LL);
			//         UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
			//           cmd,
			//           particleCullShader,
			//           particleCullKernel,
			//           vald,
			//           1,
			//           kernelIndexa,
			//           0LL);
			//         particleSortShader = data.fields.particleSortShader;
			//         threadGroupsXc = (int)sub_1801C2670();
			//         if ( nameID_4a <= 4096 )
			//         {
			//           v116 = v182[0];
			//           bitonicSortFinalKernel = data.fields.bitonicSortFinalKernel;
			//         }
			//         else
			//         {
			//           p_CB0 = data.fields.stagingLiveListBuffers;
			//           if ( !p_CB0 )
			//             goto LABEL_67;
			//           sub_18041FE6C(p_CB0, &v175, 1LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			//           v114 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(v175, 0LL);
			//           bitonicSortFinalKernel = data.fields.bitonicSortKernel;
			//           v116 = v114;
			//         }
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         p_CB0 = data.fields.stagingLiveListBuffers;
			//         vale = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._InputLiveList;
			//         if ( !p_CB0 )
			//           goto LABEL_67;
			//         sub_18041FE6C(p_CB0, &v176, 0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			//         v117 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(v176, 0LL);
			//         UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//           cmd,
			//           particleSortShader,
			//           bitonicSortFinalKernel,
			//           vale,
			//           v117,
			//           0,
			//           -1,
			//           0LL);
			//         UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//           cmd,
			//           particleSortShader,
			//           bitonicSortFinalKernel,
			//           TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._SortedLiveList,
			//           v116,
			//           0,
			//           -1,
			//           0LL);
			//         v118 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._LiveCount;
			//         v119 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(data.fields.liveCountBuffer, 0LL);
			//         UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//           cmd,
			//           particleSortShader,
			//           bitonicSortFinalKernel,
			//           v118,
			//           v119,
			//           0,
			//           -1,
			//           0LL);
			//         UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
			//           cmd,
			//           particleSortShader,
			//           bitonicSortFinalKernel,
			//           threadGroupsXc,
			//           1,
			//           1,
			//           0LL);
			//         threadGroupsXd = 0;
			//         v120 = 1;
			//         if ( nameID_4a > 4096 )
			//         {
			//           v170 = (ComputeBuffer *)nameID_4a;
			//           v121 = 0x2000;
			//           if ( nameID_4a >= 0x2000LL )
			//           {
			//             v122 = (int)sub_1801C2670();
			//             valf = v122;
			//             do
			//             {
			//               v123 = data.fields.particleSortShader;
			//               kernelIndexb = data.fields.mergeKernel;
			//               HIDWORD(v171) = v122;
			//               LODWORD(v171) = v121 >> 1;
			//               v167._dateData = v171;
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//               MergePassConstants = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._MergePassConstants;
			//               sub_180002C70(TypeInfo::UnityEngine::Rendering::ConstantBuffer);
			//               UnityEngine::Rendering::ConstantBuffer::Push<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::MergePassConstants>(
			//                 cmd,
			//                 (GPUParticleSimulationPassConstructor_MergePassConstants *)&v167,
			//                 v123,
			//                 MergePassConstants,
			//                 MethodInfo::UnityEngine::Rendering::ConstantBuffer::Push<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::MergePassConstants>);
			//               InputLiveList = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._InputLiveList;
			//               p_CB0 = data.fields.stagingLiveListBuffers;
			//               if ( !p_CB0 )
			//                 goto LABEL_67;
			//               sub_18041FE6C(p_CB0, &v177, v120);
			//               sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			//               v126 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(v177, 0LL);
			//               UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//                 cmd,
			//                 v123,
			//                 kernelIndexb,
			//                 InputLiveList,
			//                 v126,
			//                 0,
			//                 -1,
			//                 0LL);
			//               p_CB0 = data.fields.stagingLiveListBuffers;
			//               buffera = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._SortedLiveList;
			//               if ( !p_CB0 )
			//                 goto LABEL_67;
			//               sub_18041FE6C(p_CB0, &v178, threadGroupsXd);
			//               v127 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(v178, 0LL);
			//               UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//                 cmd,
			//                 v123,
			//                 kernelIndexb,
			//                 buffera,
			//                 v127,
			//                 0,
			//                 -1,
			//                 0LL);
			//               v128 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._LiveCount;
			//               v129 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(
			//                        data.fields.liveCountBuffer,
			//                        0LL);
			//               UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//                 cmd,
			//                 v123,
			//                 kernelIndexb,
			//                 v128,
			//                 v129,
			//                 0,
			//                 -1,
			//                 0LL);
			//               UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(cmd, v123, kernelIndexb, valf, 1, 1, 0LL);
			//               v122 = valf;
			//               v120 = ((_BYTE)v120 - 1) & 1;
			//               v121 *= 2;
			//               threadGroupsXd = ((_BYTE)threadGroupsXd - 1) & 1;
			//             }
			//             while ( v121 <= (__int64)v170 );
			//           }
			//           v130 = data.fields.particleSortShader;
			//           bufferb = data.fields.mergeFinalKernel;
			//           v131 = sub_1801C2670();
			//           LODWORD(v171) = v121 >> 1;
			//           HIDWORD(v171) = (int)v131;
			//           nameID_4b = (int)v131;
			//           v167._dateData = v171;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//           v132 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._MergePassConstants;
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::ConstantBuffer);
			//           UnityEngine::Rendering::ConstantBuffer::Push<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::MergePassConstants>(
			//             cmd,
			//             (GPUParticleSimulationPassConstructor_MergePassConstants *)&v167,
			//             v130,
			//             v132,
			//             MethodInfo::UnityEngine::Rendering::ConstantBuffer::Push<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::MergePassConstants>);
			//           v133 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._InputLiveList;
			//           p_CB0 = data.fields.stagingLiveListBuffers;
			//           if ( !p_CB0 )
			//             goto LABEL_67;
			//           sub_18041FE6C(p_CB0, &v179, v120);
			//           sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			//           v134 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(v179, 0LL);
			//           UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//             cmd,
			//             v130,
			//             bufferb,
			//             v133,
			//             v134,
			//             0,
			//             -1,
			//             0LL);
			//           UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//             cmd,
			//             v130,
			//             bufferb,
			//             TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._SortedLiveList,
			//             v182[0],
			//             0,
			//             -1,
			//             0LL);
			//           v135 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._LiveCount;
			//           v136 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(data.fields.liveCountBuffer, 0LL);
			//           UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//             cmd,
			//             v130,
			//             bufferb,
			//             v135,
			//             v136,
			//             0,
			//             -1,
			//             0LL);
			//           UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(cmd, v130, bufferb, nameID_4b, 1, 1, 0LL);
			//         }
			//         particleIndirectArgsShader = data.fields.particleIndirectArgsShader;
			//         particleIndirectArgsKernel = data.fields.particleIndirectArgsKernel;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         liveCountBuffer = data.fields.liveCountBuffer;
			//         v140 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._LiveCount;
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			//         v141 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(liveCountBuffer, 0LL);
			//         UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//           cmd,
			//           particleIndirectArgsShader,
			//           particleIndirectArgsKernel,
			//           v140,
			//           v141,
			//           0,
			//           -1,
			//           0LL);
			//         UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//           cmd,
			//           particleIndirectArgsShader,
			//           particleIndirectArgsKernel,
			//           TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._DrawIndirectArg,
			//           (ComputeBuffer *)_mm_srli_si128(v17, 8).m128i_i64[0],
			//           0,
			//           -1,
			//           0LL);
			//         UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
			//           cmd,
			//           particleIndirectArgsShader,
			//           particleIndirectArgsKernel,
			//           1,
			//           1,
			//           1,
			//           0LL);
			//         seed = dataa[0].seed;
			//       }
			//       dataa[0].seed = ++seed;
			//     }
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2677, 0LL);
			//   if ( !Patch )
			//     goto LABEL_67;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//     (ILFixDynamicMethodWrapper_28 *)Patch,
			//     (Object *)sysList,
			//     (Object *)data,
			//     (Object *)context,
			//     0LL);
			// }
			// 
		}

		internal void ConstructPass(in GPUParticleSimulationPassConstructor.PassInput input, ref GPUParticleSimulationPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(GPUParticleSimulationPassConstructor+PassInput ByRef, GPUParticleSimulationPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::ConstructPass(
			//         GPUParticleSimulationPassConstructor *this,
			//         GPUParticleSimulationPassConstructor_PassInput *input,
			//         GPUParticleSimulationPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   Object *v6; // r12
			//   GPUParticleSimulationPassConstructor *v9; // rsi
			//   GPUParticleSystemManager *instance; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   GPUParticleSystemManager *v13; // rax
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   int32_t maxGPUInstanceCount_k__BackingField; // r14d
			//   GPUParticleSystemManager *v17; // rax
			//   __int64 v18; // rdx
			//   __int64 v19; // rcx
			//   __int64 v20; // rdx
			//   __int64 v21; // rcx
			//   __int64 v22; // rdx
			//   __int64 v23; // rcx
			//   __int64 v24; // rdx
			//   __int64 v25; // rcx
			//   __int64 v26; // rdx
			//   __int64 v27; // rcx
			//   List_1_System_Int32_ *m_receivers; // rbx
			//   GPUParticleSystemManager *v29; // rax
			//   __int64 v30; // rdx
			//   __int64 v31; // rcx
			//   ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ *Span; // rax
			//   __int64 v33; // rdx
			//   __int64 v34; // rcx
			//   ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ v35; // xmm1
			//   int v36; // r13d
			//   int length; // r15d
			//   __int64 *v38; // rax
			//   bool v39; // cf
			//   __int64 v40; // rbx
			//   OneofDescriptorProto *v41; // rdx
			//   FileDescriptor *v42; // r8
			//   MessageDescriptor *v43; // r9
			//   __int64 v44; // rdx
			//   __int64 v45; // rcx
			//   GPUParticleSimulationPassConstructor_PassInput *v46; // rdx
			//   unsigned __int64 v47; // rcx
			//   __m128i v48; // xmm6
			//   unsigned __int64 v49; // rax
			//   __int64 v50; // rdx
			//   __int64 v51; // rcx
			//   __m128d v52; // xmm6
			//   DynamicArray_1_HG_Rendering_Runtime_GPUParticleSimulationPassConstructor_SimulateRequiredResources_ *m_simulateList; // rbx
			//   int32_t v54; // ebx
			//   __int64 v55; // rdx
			//   __int64 v56; // rcx
			//   Il2CppException *v57; // rax
			//   ProjectileComponent_FinishOptions v58; // rdx
			//   ProjectileComponent_FinishOptions v59; // rcx
			//   int32_t v60; // ebx
			//   Dictionary_2_System_Guid_System_Int32_ *m_gpuEventDict; // r15
			//   DynamicArray_1_HG_Rendering_Runtime_GPUParticleSimulationPassConstructor_SimulateRequiredResources_ *m_senderSimulateList; // r14
			//   int32_t size_k__BackingField; // r14d
			//   __int64 v64; // rdx
			//   __int64 v65; // rcx
			//   DynamicArray_1_HG_Rendering_Runtime_GPUParticleSimulationPassConstructor_SimulateRequiredResources_ *v66; // rbx
			//   __int64 v67; // rdx
			//   int32_t current; // ebx
			//   Dictionary_2_System_Guid_System_Int32_ *v69; // r14
			//   DynamicArray_1_HG_Rendering_Runtime_GPUParticleSimulationPassConstructor_SimulateRequiredResources_ *v70; // rcx
			//   GPUParticleSimulationPassConstructor_SimulateRequiredResources *Item; // rax
			//   __int64 v72; // rdx
			//   __int64 v73; // rcx
			//   __int64 v74; // rdx
			//   DynamicArray_1_HG_Rendering_Runtime_GPUParticleSimulationPassConstructor_SimulateRequiredResources_ *v75; // rcx
			//   __int64 v76; // rdx
			//   DynamicArray_1_HG_Rendering_Runtime_GPUParticleSimulationPassConstructor_SimulateRequiredResources_ *v77; // rcx
			//   GPUParticleSimulationPassConstructor_SimulateRequiredResources *v78; // rax
			//   __int64 v79; // rdx
			//   DynamicArray_1_HG_Rendering_Runtime_GPUParticleSimulationPassConstructor_SimulateRequiredResources_ *v80; // rcx
			//   GPUParticleSimulationPassConstructor_SimulateRequiredResources *v81; // rax
			//   DynamicArray_1_HG_Rendering_Runtime_GPUParticleSimulationPassConstructor_SimulateRequiredResources_ *v82; // rcx
			//   GPUParticleSimulationPassConstructor_SimulateRequiredResources *v83; // rbx
			//   __int64 v84; // rdx
			//   __int64 v85; // rcx
			//   int32_t v86; // r15d
			//   ProfilingSampler *v87; // rax
			//   __int64 v88; // rdx
			//   __int64 v89; // rcx
			//   DynamicArray_1_HG_Rendering_Runtime_GPUParticleSimulationPassConstructor_SimulateRequiredResources_ *v90; // rax
			//   GPUParticleSimulationPassConstructor_SimulateRequiredResources *v91; // rax
			//   __int64 v92; // rdx
			//   __int64 v93; // rcx
			//   int32_t i; // ebx
			//   int32_t j; // ebx
			//   DynamicArray_1_HG_Rendering_Runtime_GPUParticleSimulationPassConstructor_SimulateRequiredResources_ *v96; // rax
			//   GPUParticleSimulationPassConstructor_SimulateRequiredResources *v97; // rax
			//   int k; // ebx
			//   MonitorData *monitor; // r14
			//   unsigned __int64 v100; // r8
			//   signed __int64 v101; // rtt
			//   ComputeBufferHandle v102; // rax
			//   ComputeBufferHandle v103; // rcx
			//   ComputeBufferHandle v104; // r8
			//   ComputeBufferHandle v105; // r9
			//   ComputeBufferHandle *v106; // rbx
			//   ComputeBufferHandle v107; // rax
			//   ComputeBufferHandle v108; // rdx
			//   ComputeBufferHandle v109; // rcx
			//   ComputeBufferHandle *v110; // rbx
			//   ComputeBufferHandle v111; // rax
			//   ComputeBufferHandle v112; // rdx
			//   ComputeBufferHandle v113; // rcx
			//   Object *v114; // rdx
			//   __int64 v115; // rcx
			//   unsigned __int64 v116; // rdx
			//   unsigned __int64 v117; // r8
			//   char v118; // dl
			//   signed __int64 v119; // rtt
			//   Object *v120; // rdx
			//   unsigned __int64 v121; // rdx
			//   unsigned __int64 v122; // r8
			//   char v123; // dl
			//   signed __int64 v124; // rtt
			//   Object *v125; // rdx
			//   unsigned __int64 v126; // rdx
			//   unsigned __int64 v127; // r8
			//   char v128; // dl
			//   signed __int64 v129; // rtt
			//   Object *v130; // rdx
			//   unsigned __int64 v131; // rdx
			//   unsigned __int64 v132; // r8
			//   char v133; // dl
			//   signed __int64 v134; // rtt
			//   Object *v135; // rdx
			//   unsigned __int64 v136; // rdx
			//   unsigned __int64 v137; // r8
			//   char v138; // dl
			//   signed __int64 v139; // rtt
			//   __int64 m_particleCleanupKernel; // rdx
			//   __int64 m_particleInitKernel; // rdx
			//   __int64 m_particleCullKernel; // rdx
			//   __int64 m_bitonicSortKernel; // rdx
			//   __int64 m_bitonicSortFinalKernel; // rdx
			//   __int64 m_mergeKernel; // rdx
			//   __int64 m_mergeFinalKernel; // rdx
			//   __int64 m_particleIndirectArgsKernel; // rdx
			//   Object *v148; // rdx
			//   unsigned __int64 v149; // rdx
			//   unsigned __int64 v150; // r8
			//   char v151; // dl
			//   signed __int64 v152; // rtt
			//   Object *v153; // rdx
			//   unsigned __int64 v154; // rdx
			//   unsigned __int64 v155; // r8
			//   char v156; // dl
			//   signed __int64 v157; // rtt
			//   Object *v158; // rdx
			//   unsigned __int64 v159; // rdx
			//   unsigned __int64 v160; // r8
			//   char v161; // dl
			//   signed __int64 v162; // rtt
			//   Object *v163; // rdx
			//   MonitorData *v164; // xmm1_8
			//   unsigned __int64 v165; // rdx
			//   unsigned __int64 v166; // r8
			//   char v167; // dl
			//   signed __int64 v168; // rtt
			//   Object *v169; // rdx
			//   Object__Class *v170; // xmm1_8
			//   unsigned __int64 v171; // rdx
			//   unsigned __int64 v172; // r8
			//   char v173; // dl
			//   signed __int64 v174; // rtt
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v176; // rdx
			//   __int64 v177; // rcx
			//   MethodInfo *v178; // [rsp+20h] [rbp-2D8h]
			//   Object *P4; // [rsp+28h] [rbp-2D0h]
			//   MethodInfo *v180; // [rsp+30h] [rbp-2C8h]
			//   Object *v181; // [rsp+40h] [rbp-2B8h] BYREF
			//   ComputeBufferHandle inputa; // [rsp+48h] [rbp-2B0h] BYREF
			//   ComputeBufferDesc desc; // [rsp+50h] [rbp-2A8h] BYREF
			//   Il2CppException *ex; // [rsp+68h] [rbp-290h]
			//   List_1_T_Enumerator_System_UInt32_ *v185; // [rsp+70h] [rbp-288h]
			//   ComputeBufferDesc v186; // [rsp+78h] [rbp-280h] BYREF
			//   int32_t index; // [rsp+90h] [rbp-268h] BYREF
			//   int32_t maxParticleCount_k__BackingField; // [rsp+94h] [rbp-264h]
			//   int32_t v189; // [rsp+98h] [rbp-260h]
			//   int v190; // [rsp+9Ch] [rbp-25Ch]
			//   _BYTE v191[20]; // [rsp+A0h] [rbp-258h]
			//   __int128 v192; // [rsp+B8h] [rbp-240h]
			//   _BYTE v193[24]; // [rsp+C8h] [rbp-230h] BYREF
			//   _QWORD v194[2]; // [rsp+E0h] [rbp-218h] BYREF
			//   HGRenderGraphBuilder v195; // [rsp+F0h] [rbp-208h] BYREF
			//   HGRenderGraphBuilder v196; // [rsp+110h] [rbp-1E8h] BYREF
			//   Guid guid; // [rsp+130h] [rbp-1C8h] BYREF
			//   OptionalSystemFeatures v198; // [rsp+140h] [rbp-1B8h] BYREF
			//   List_1_T_Enumerator_System_UInt32_ v199; // [rsp+170h] [rbp-188h] BYREF
			//   GPUParticleSimulationPassConstructor_SimulateRequiredResources value; // [rsp+190h] [rbp-168h] BYREF
			//   OptionalSystemFeatures v201; // [rsp+200h] [rbp-F8h] BYREF
			//   Il2CppExceptionWrapper *v202; // [rsp+230h] [rbp-C8h] BYREF
			//   Il2CppExceptionWrapper *v203; // [rsp+238h] [rbp-C0h] BYREF
			//   OneofDescriptor v204; // [rsp+240h] [rbp-B8h] BYREF
			//   __int128 v205; // [rsp+290h] [rbp-68h]
			//   __int128 v206; // [rsp+2A0h] [rbp-58h]
			// 
			//   v6 = (Object *)renderGraph;
			//   v9 = this;
			//   if ( !byte_18D91956E )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::Guid,int>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::Guid,int>::TryGetValue);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::Guid,int>::set_Item);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::Add);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::Clear);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_size);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::get_Current);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::GPUParticleSimulationPassConstructor);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::PassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::PassData>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::GPUEventFeature>::get_HasValue);
			//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::OptionalSystemFeatures>::get_HasValue);
			//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::GPUEventSender>::get_HasValue);
			//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::SceneRTFeature>::get_HasValue);
			//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::GPUEventFeature>::get_Value);
			//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::GPUEventSender>::get_Value);
			//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::OptionalSystemFeatures>::get_Value);
			//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::SceneRTFeature>::get_Value);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&MethodInfo::System::ReadOnlySpan<HG::Rendering::Runtime::GPUParticleSystemBase>::get_Length);
			//     sub_18003C530(&off_18D4FD650);
			//     sub_18003C530(&off_18D4FD660);
			//     byte_18D91956E = 1;
			//   }
			//   sub_1802F01E0(&v204, 0LL, 112LL);
			//   *(_OWORD *)v191 = 0LL;
			//   v192 = 0LL;
			//   *(_OWORD *)v193 = 0LL;
			//   memset(&desc, 0, sizeof(desc));
			//   memset(&v186, 0, sizeof(v186));
			//   index = 0;
			//   memset(&v195, 0, sizeof(v195));
			//   v181 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2678, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2678, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v177, v176);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_981(Patch, (Object *)v9, input, output, v6, (Object *)camera, 0LL);
			//   }
			//   else
			//   {
			//     instance = HG::Rendering::Runtime::GPUParticleSystemManager::get_instance(0LL);
			//     if ( !instance )
			//       sub_180B536AC(v12, v11);
			//     maxParticleCount_k__BackingField = instance.fields._maxParticleCount_k__BackingField;
			//     v13 = HG::Rendering::Runtime::GPUParticleSystemManager::get_instance(0LL);
			//     if ( !v13 )
			//       sub_180B536AC(v15, v14);
			//     maxGPUInstanceCount_k__BackingField = v13.fields._maxGPUInstanceCount_k__BackingField;
			//     v189 = maxGPUInstanceCount_k__BackingField;
			//     v17 = HG::Rendering::Runtime::GPUParticleSystemManager::get_instance(0LL);
			//     if ( !v17 )
			//       sub_180B536AC(v19, v18);
			//     if ( !HG::Rendering::Runtime::GPUParticleSystemManager::Empty(v17, 0LL) && maxGPUInstanceCount_k__BackingField )
			//     {
			//       if ( !v9.fields.m_simulateList )
			//         sub_180B536AC(v21, v20);
			//       UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Clear(
			//         (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)v9.fields.m_simulateList,
			//         MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::Clear);
			//       if ( !v9.fields.m_senderSimulateList )
			//         sub_180B536AC(v23, v22);
			//       UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Clear(
			//         (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)v9.fields.m_senderSimulateList,
			//         MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::Clear);
			//       if ( !v9.fields.m_gpuEventDict )
			//         sub_180B536AC(v25, v24);
			//       System::Collections::Generic::Dictionary<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::Clear(
			//         (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)v9.fields.m_gpuEventDict,
			//         MethodInfo::System::Collections::Generic::Dictionary<System::Guid,int>::Clear);
			//       m_receivers = v9.fields.m_receivers;
			//       if ( !m_receivers )
			//         sub_180B536AC(v27, v26);
			//       ++m_receivers.fields._version;
			//       m_receivers.fields._size = 0;
			//       v29 = HG::Rendering::Runtime::GPUParticleSystemManager::get_instance(0LL);
			//       if ( !v29 )
			//         sub_180B536AC(v31, v30);
			//       Span = HG::Rendering::Runtime::GPUParticleSystemManager::GetSpan(
			//                (ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ *)&guid,
			//                v29,
			//                0LL);
			//       v35 = *Span;
			//       v36 = 0;
			//       length = Span._length;
			//       v190 = length;
			//       if ( length > 0 )
			//       {
			//         v38 = (__int64 *)v35._pointer._value;
			//         inputa = (ComputeBufferHandle)v35._pointer._value;
			//         v39 = length != 0;
			//         do
			//         {
			//           if ( !v39 )
			//             sub_180070270(v34, v33);
			//           v40 = *v38;
			//           if ( *v38 )
			//           {
			//             sub_1802F01E0(&v204.monitor, 0LL, 104LL);
			//             v204.klass = (OneofDescriptor__Class *)v40;
			//             sub_1800054D0(&v204, v41, v42, v43, (String__Array *)v178, (String *)P4, v180);
			//             *(_OWORD *)&value.gpuParticleSystem = *(_OWORD *)&v204.klass;
			//             *(OneofDescriptor__Fields *)&value.depthOnlyRT.texture.handle._type_k__BackingField = v204.fields;
			//             *(_OWORD *)&value.gpuEventData.sentCountBuffer.handle._type_k__BackingField = v205;
			//             *(_OWORD *)&value.gpuEventData.guid._b = v206;
			//             if ( *(_BYTE *)(v40 + 160) )
			//             {
			//               System::Nullable<HG::Rendering::Runtime::OptionalSystemFeatures>::get_Value(
			//                 &v198,
			//                 (Nullable_1_HG_Rendering_Runtime_OptionalSystemFeatures_ *)(v40 + 160),
			//                 MethodInfo::System::Nullable<HG::Rendering::Runtime::OptionalSystemFeatures>::get_Value);
			//               v48 = *(__m128i *)&v198.sceneRTFeature.hasValue;
			//               v201 = v198;
			//               if ( (unsigned __int8)_mm_cvtsi128_si32(*(__m128i *)&v198.sceneRTFeature.hasValue) )
			//               {
			//                 v49 = (unsigned __int64)System::Nullable<Beyond::Gameplay::Core::ProjectileComponent::FinishOptions>::get_Value(
			//                                           (Nullable_1_Beyond_Gameplay_Core_ProjectileComponent_FinishOptions_ *)&v201,
			//                                           MethodInfo::System::Nullable<HG::Rendering::Runtime::SceneRTFeature>::get_Value);
			//                 v46 = input;
			//                 if ( (_DWORD)v49 )
			//                 {
			//                   *(_DWORD *)v191 = v49;
			//                   *(TextureHandle *)&v191[4] = input.sceneNormal;
			//                   *(_OWORD *)&value.sceneNormal.shaderID = *(_OWORD *)v191;
			//                   value.sceneNormal.texture.fallBackResource._type_k__BackingField = _mm_cvtsi128_si32(
			//                                                                                        _mm_srli_si128(
			//                                                                                          *(__m128i *)&v191[4],
			//                                                                                          12));
			//                 }
			//                 v47 = HIDWORD(v49);
			//                 if ( HIDWORD(v49) )
			//                 {
			//                   *(_DWORD *)v191 = HIDWORD(v49);
			//                   *(TextureHandle *)&v191[4] = input.sceneDepth;
			//                   *(_OWORD *)&value.sceneDepth.shaderID = *(_OWORD *)v191;
			//                   value.sceneDepth.texture.fallBackResource._type_k__BackingField = _mm_cvtsi128_si32(
			//                                                                                       _mm_srli_si128(
			//                                                                                         *(__m128i *)&v191[4],
			//                                                                                         12));
			//                 }
			//               }
			//               if ( !(unsigned __int8)_mm_cvtsi128_si32(_mm_srli_si128(v48, 12)) )
			//                 goto LABEL_37;
			//               System::Nullable<UnityEngine::Keyframe>::get_Value(
			//                 (Keyframe *)&v198,
			//                 (Nullable_1_UnityEngine_Keyframe_ *)&v201.gpuEventFeature,
			//                 MethodInfo::System::Nullable<HG::Rendering::Runtime::GPUEventFeature>::get_Value);
			//               v52 = *(__m128d *)&v198.sceneRTFeature.hasValue;
			//               *(_OWORD *)&v196.m_RenderPass = *(_OWORD *)&v198.sceneRTFeature.hasValue;
			//               v196.m_RenderGraph = *(HGRenderGraph **)&v198.gpuEventFeature.value.guid._a;
			//               *(_DWORD *)&v196.m_Disposed = *(_DWORD *)&v198.gpuEventFeature.value.guid._d;
			//               if ( LOBYTE(v198.gpuEventFeature.value.guid._a) )
			//               {
			//                 v57 = (Il2CppException *)System::Nullable<Beyond::Gameplay::Core::ProjectileComponent::FinishOptions>::get_Value(
			//                                            (Nullable_1_Beyond_Gameplay_Core_ProjectileComponent_FinishOptions_ *)&v196.m_RenderGraph,
			//                                            MethodInfo::System::Nullable<HG::Rendering::Runtime::GPUEventSender>::get_Value);
			//                 v60 = (int)v57;
			//                 ex = v57;
			//                 m_gpuEventDict = v9.fields.m_gpuEventDict;
			//                 m_senderSimulateList = v9.fields.m_senderSimulateList;
			//                 if ( !m_senderSimulateList )
			//                   sub_180B536AC(v59, v58);
			//                 size_k__BackingField = m_senderSimulateList.fields._size_k__BackingField;
			//                 if ( !m_gpuEventDict )
			//                   sub_180B536AC(v59, v58);
			//                 guid = (Guid)v52;
			//                 System::Collections::Generic::Dictionary<System::Guid,int>::set_Item(
			//                   m_gpuEventDict,
			//                   &guid,
			//                   size_k__BackingField,
			//                   MethodInfo::System::Collections::Generic::Dictionary<System::Guid,int>::set_Item);
			//                 memset(v193, 0, sizeof(v193));
			//                 v52 = 0LL;
			//                 *(_QWORD *)(&desc.type + 1) = 0LL;
			//                 HIDWORD(desc.name) = 0;
			//                 desc.count = 1;
			//                 desc.stride = 4;
			//                 desc.type = 4;
			//                 if ( !v6 )
			//                   sub_180B536AC(v65, v64);
			//                 *((ComputeBufferHandle *)&v192 + 1) = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateComputeBuffer(
			//                                                         (HGRenderGraph *)v6,
			//                                                         &desc,
			//                                                         0LL);
			//                 *(_QWORD *)(&v186.type + 1) = 0LL;
			//                 HIDWORD(v186.name) = 0;
			//                 v186.count = v60;
			//                 v186.stride = HIDWORD(ex);
			//                 v186.type = 16;
			//                 *(ComputeBufferHandle *)&v192 = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateComputeBuffer(
			//                                                   (HGRenderGraph *)v6,
			//                                                   &v186,
			//                                                   0LL);
			//                 length = v190;
			//               }
			//               else
			//               {
			//                 m_simulateList = v9.fields.m_simulateList;
			//                 if ( !m_simulateList )
			//                   sub_180B536AC(v51, v50);
			//                 v54 = m_simulateList.fields._size_k__BackingField;
			//                 if ( !v9.fields.m_receivers )
			//                   sub_180B536AC(v51, v50);
			//                 sub_18231EF50(v9.fields.m_receivers, v54);
			//                 v192 = 0uLL;
			//                 *(_QWORD *)(&desc.type + 1) = 0LL;
			//                 HIDWORD(desc.name) = 0;
			//                 desc.count = 1;
			//                 desc.stride = 4;
			//                 desc.type = 4;
			//                 if ( !v6 )
			//                   sub_180B536AC(v56, v55);
			//                 *(ComputeBufferHandle *)v193 = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateComputeBuffer(
			//                                                  (HGRenderGraph *)v6,
			//                                                  &desc,
			//                                                  0LL);
			//                 *(__m128d *)&v193[8] = v52;
			//               }
			//               *(_QWORD *)&value.gpuEventData.guid._d = *(_OWORD *)&_mm_unpackhi_pd(v52, v52);
			//               *(_OWORD *)&value.gpuEventData.comsumedCountBuffer.handle.m_Value = *(_OWORD *)v193;
			//               *(_OWORD *)&value.gpuEventData.eventBuffer.handle.m_Value = v192;
			//               if ( LOBYTE(v198.gpuEventFeature.value.guid._a) )
			//               {
			//                 v66 = v9.fields.m_senderSimulateList;
			//                 if ( !v66 )
			//                   sub_180B536AC(v47, v46);
			//               }
			//               else
			//               {
			// LABEL_37:
			//                 v66 = v9.fields.m_simulateList;
			//                 if ( !v66 )
			//                   sub_180B536AC(v47, v46);
			//               }
			//             }
			//             else
			//             {
			//               v66 = v9.fields.m_simulateList;
			//               if ( !v66 )
			//                 sub_180B536AC(v45, v44);
			//             }
			//             UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::Add(
			//               v66,
			//               &value,
			//               MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::Add);
			//             v38 = (__int64 *)inputa;
			//           }
			//           ++v36;
			//           inputa = (ComputeBufferHandle)++v38;
			//           v39 = v36 < (unsigned int)length;
			//         }
			//         while ( v36 < length );
			//       }
			//       if ( !v9.fields.m_receivers )
			//         sub_180B536AC(v34, v33);
			//       System::Collections::Generic::List<int>::GetEnumerator(
			//         (List_1_T_Enumerator_System_Int32_ *)&v186,
			//         v9.fields.m_receivers,
			//         MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
			//       v199 = (List_1_T_Enumerator_System_UInt32_)v186;
			//       ex = 0LL;
			//       v185 = &v199;
			//       try
			//       {
			//         while ( System::Collections::Generic::List_1_T_::Enumerator<unsigned int>::MoveNext(
			//                   &v199,
			//                   MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext) )
			//         {
			//           current = v199._current;
			//           v69 = v9.fields.m_gpuEventDict;
			//           v70 = v9.fields.m_simulateList;
			//           if ( !v70 )
			//             sub_1802DC2C8(0LL, v67);
			//           Item = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                    v70,
			//                    v199._current,
			//                    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item);
			//           if ( !v69 )
			//             sub_1802DC2C8(v73, v72);
			//           guid = Item.gpuEventData.guid;
			//           if ( System::Collections::Generic::Dictionary<System::Guid,int>::TryGetValue(
			//                  v69,
			//                  &guid,
			//                  &index,
			//                  MethodInfo::System::Collections::Generic::Dictionary<System::Guid,int>::TryGetValue) )
			//           {
			//             v75 = v9.fields.m_senderSimulateList;
			//             if ( !v75 )
			//               sub_1802DC2C8(0LL, v74);
			//             v192 = *(_OWORD *)&UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                                  v75,
			//                                  index,
			//                                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item).gpuEventData.eventBuffer.handle.m_Value;
			//             v77 = v9.fields.m_simulateList;
			//             if ( !v77 )
			//               sub_1802DC2C8(0LL, v76);
			//             v78 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                     v77,
			//                     current,
			//                     MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item);
			//             v78.gpuEventData.eventBuffer = (ComputeBufferHandle)v192;
			//             v80 = v9.fields.m_simulateList;
			//             if ( !v80 )
			//               sub_1802DC2C8(0LL, v79);
			//             v81 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                     v80,
			//                     current,
			//                     MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item);
			//             v81.gpuEventData.sentCountBuffer = (ComputeBufferHandle)*((_QWORD *)&v192 + 1);
			//           }
			//           else
			//           {
			//             v82 = v9.fields.m_simulateList;
			//             if ( !v82 )
			//               sub_1802DC2C8(0LL, v74);
			//             v83 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                     v82,
			//                     current,
			//                     MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item);
			//             sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			//             v83.gpuEventData.eventBuffer = (ComputeBufferHandle)sub_182E10C50(v85, v84);
			//           }
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v202 )
			//       {
			//         ex = v202.ex;
			//         if ( ex )
			//           sub_18000F780(ex);
			//         v6 = (Object *)renderGraph;
			//         v9 = this;
			//         v86 = maxParticleCount_k__BackingField;
			//         goto LABEL_57;
			//       }
			//       v86 = maxParticleCount_k__BackingField;
			// LABEL_57:
			//       v87 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0xB2u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       if ( !v6 )
			//         sub_1802DC2C8(v89, v88);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         &v196,
			//         (HGRenderGraph *)v6,
			//         (String *)"Particle Simulation",
			//         &v181,
			//         v87,
			//         1,
			//         ProfilingHGPass__Enum_None,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::PassData>);
			//       v195 = v196;
			//       v194[0] = 0LL;
			//       v194[1] = &v195;
			//       try
			//       {
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v195, 0, 0LL);
			//         for ( i = 0; ; ++i )
			//         {
			//           v90 = v9.fields.m_senderSimulateList;
			//           if ( !v90 )
			//             sub_1802DC2C8(v93, v92);
			//           if ( i >= v90.fields._size_k__BackingField )
			//             break;
			//           v91 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                   v9.fields.m_senderSimulateList,
			//                   i,
			//                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item);
			//           v196 = v195;
			//           HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources::MarkResourceRead(
			//             v91,
			//             &v196,
			//             0LL);
			//         }
			//         for ( j = 0; ; ++j )
			//         {
			//           v96 = v9.fields.m_simulateList;
			//           if ( !v96 )
			//             sub_1802DC2C8(v93, v92);
			//           if ( j >= v96.fields._size_k__BackingField )
			//             break;
			//           v97 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
			//                   v9.fields.m_simulateList,
			//                   j,
			//                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item);
			//           v196 = v195;
			//           HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources::MarkResourceRead(
			//             v97,
			//             &v196,
			//             0LL);
			//         }
			//         for ( k = 0; k < 2; ++k )
			//         {
			//           if ( !v181 )
			//             sub_1802DC2C8(v93, v92);
			//           monitor = v181[5].monitor;
			//           *(_QWORD *)&desc.type = 16LL;
			//           desc.count = v86;
			//           desc.stride = 8;
			//           desc.name = (String *)"PerFrameParticleSimulateBuffer";
			//           if ( dword_18D8E43F8 )
			//           {
			//             v100 = (((unsigned __int64)&desc.name >> 12) & 0x1FFFFF) >> 6;
			//             _m_prefetchw(&qword_18D6405E0[v100 + 36190]);
			//             do
			//               v101 = qword_18D6405E0[v100 + 36190];
			//             while ( v101 != _InterlockedCompareExchange64(
			//                               &qword_18D6405E0[v100 + 36190],
			//                               v101 | (1LL << (((unsigned __int64)&desc.name >> 12) & 0x3F)),
			//                               v101) );
			//           }
			//           inputa = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateComputeBuffer((HGRenderGraph *)v6, &desc, 0LL);
			//           v102 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteComputeBuffer(&v195, &inputa, 0LL);
			//           if ( !monitor )
			//             sub_1802DC2C8(v103, v92);
			//           v93 = k;
			//           if ( (unsigned int)k >= *((_DWORD *)monitor + 6) )
			//             ((void (__fastcall __noreturn *)(_QWORD, _QWORD, _QWORD, _QWORD))sub_180070260)(k, v92, v104, v105);
			//           *((ComputeBufferHandle *)monitor + k + 4) = v102;
			//         }
			//         v106 = (ComputeBufferHandle *)v181;
			//         *(_QWORD *)(&v186.type + 1) = 0LL;
			//         HIDWORD(v186.name) = 0;
			//         v186.count = 2 * v189;
			//         v186.stride = 4;
			//         v186.type = 16;
			//         *(_OWORD *)&desc.count = *(_OWORD *)&v186.count;
			//         desc.name = 0LL;
			//         inputa = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateComputeBuffer((HGRenderGraph *)v6, &desc, 0LL);
			//         v107 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteComputeBuffer(&v195, &inputa, 0LL);
			//         if ( !v106 )
			//           sub_1802DC2C8(v109, v108);
			//         v106[12] = v107;
			//         v110 = (ComputeBufferHandle *)v181;
			//         *(_QWORD *)(&v186.type + 1) = 0LL;
			//         HIDWORD(v186.name) = 0;
			//         v186.count = 1;
			//         v186.stride = 4;
			//         v186.type = 16;
			//         *(_OWORD *)&desc.count = *(_OWORD *)&v186.count;
			//         desc.name = 0LL;
			//         inputa = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateComputeBuffer((HGRenderGraph *)v6, &desc, 0LL);
			//         v111 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteComputeBuffer(&v195, &inputa, 0LL);
			//         if ( !v110 )
			//           sub_1802DC2C8(v113, v112);
			//         v110[13] = v111;
			//         v114 = v181;
			//         if ( !v181 )
			//           sub_1802DC2C8(v113, 0LL);
			//         v181[1].klass = (Object__Class *)v9.fields.m_particleCleanupShader;
			//         v115 = (unsigned int)dword_18D8E43F8;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v116 = ((unsigned __int64)&v114[1] >> 12) & 0x1FFFFF;
			//           v117 = v116 >> 6;
			//           v118 = v116 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v117 + 36190]);
			//           do
			//             v119 = qword_18D6405E0[v117 + 36190];
			//           while ( v119 != _InterlockedCompareExchange64(&qword_18D6405E0[v117 + 36190], v119 | (1LL << v118), v119) );
			//           v115 = (unsigned int)dword_18D8E43F8;
			//         }
			//         v120 = v181;
			//         if ( !v181 )
			//           sub_1802DC2C8(v115, 0LL);
			//         v181[1].monitor = (MonitorData *)v9.fields.m_particleInitShader;
			//         if ( (_DWORD)v115 )
			//         {
			//           v121 = ((unsigned __int64)&v120[1].monitor >> 12) & 0x1FFFFF;
			//           v122 = v121 >> 6;
			//           v123 = v121 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v122 + 36190]);
			//           do
			//             v124 = qword_18D6405E0[v122 + 36190];
			//           while ( v124 != _InterlockedCompareExchange64(&qword_18D6405E0[v122 + 36190], v124 | (1LL << v123), v124) );
			//           v115 = (unsigned int)dword_18D8E43F8;
			//         }
			//         v125 = v181;
			//         if ( !v181 )
			//           sub_1802DC2C8(v115, 0LL);
			//         v181[2].klass = (Object__Class *)v9.fields.m_particleCullShader;
			//         if ( (_DWORD)v115 )
			//         {
			//           v126 = ((unsigned __int64)&v125[2] >> 12) & 0x1FFFFF;
			//           v127 = v126 >> 6;
			//           v128 = v126 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v127 + 36190]);
			//           do
			//             v129 = qword_18D6405E0[v127 + 36190];
			//           while ( v129 != _InterlockedCompareExchange64(&qword_18D6405E0[v127 + 36190], v129 | (1LL << v128), v129) );
			//           v115 = (unsigned int)dword_18D8E43F8;
			//         }
			//         v130 = v181;
			//         if ( !v181 )
			//           sub_1802DC2C8(v115, 0LL);
			//         v181[2].monitor = (MonitorData *)v9.fields.m_particleSortShader;
			//         if ( (_DWORD)v115 )
			//         {
			//           v131 = ((unsigned __int64)&v130[2].monitor >> 12) & 0x1FFFFF;
			//           v132 = v131 >> 6;
			//           v133 = v131 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v132 + 36190]);
			//           do
			//             v134 = qword_18D6405E0[v132 + 36190];
			//           while ( v134 != _InterlockedCompareExchange64(&qword_18D6405E0[v132 + 36190], v134 | (1LL << v133), v134) );
			//           v115 = (unsigned int)dword_18D8E43F8;
			//         }
			//         v135 = v181;
			//         if ( !v181 )
			//           sub_1802DC2C8(v115, 0LL);
			//         v181[3].klass = (Object__Class *)v9.fields.m_particleIndirectArgsShader;
			//         if ( (_DWORD)v115 )
			//         {
			//           v136 = ((unsigned __int64)&v135[3] >> 12) & 0x1FFFFF;
			//           v137 = v136 >> 6;
			//           v138 = v136 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v137 + 36190]);
			//           do
			//             v139 = qword_18D6405E0[v137 + 36190];
			//           while ( v139 != _InterlockedCompareExchange64(&qword_18D6405E0[v137 + 36190], v139 | (1LL << v138), v139) );
			//           v115 = (unsigned int)dword_18D8E43F8;
			//         }
			//         m_particleCleanupKernel = (unsigned int)v9.fields.m_particleCleanupKernel;
			//         if ( !v181 )
			//           sub_1802DC2C8(v115, m_particleCleanupKernel);
			//         LODWORD(v181[3].monitor) = m_particleCleanupKernel;
			//         m_particleInitKernel = (unsigned int)v9.fields.m_particleInitKernel;
			//         if ( !v181 )
			//           sub_1802DC2C8(v115, m_particleInitKernel);
			//         HIDWORD(v181[3].monitor) = m_particleInitKernel;
			//         m_particleCullKernel = (unsigned int)v9.fields.m_particleCullKernel;
			//         if ( !v181 )
			//           sub_1802DC2C8(v115, m_particleCullKernel);
			//         LODWORD(v181[4].klass) = m_particleCullKernel;
			//         m_bitonicSortKernel = (unsigned int)v9.fields.m_bitonicSortKernel;
			//         if ( !v181 )
			//           sub_1802DC2C8(v115, m_bitonicSortKernel);
			//         HIDWORD(v181[4].klass) = m_bitonicSortKernel;
			//         m_bitonicSortFinalKernel = (unsigned int)v9.fields.m_bitonicSortFinalKernel;
			//         if ( !v181 )
			//           sub_1802DC2C8(v115, m_bitonicSortFinalKernel);
			//         LODWORD(v181[4].monitor) = m_bitonicSortFinalKernel;
			//         m_mergeKernel = (unsigned int)v9.fields.m_mergeKernel;
			//         if ( !v181 )
			//           sub_1802DC2C8(v115, m_mergeKernel);
			//         HIDWORD(v181[4].monitor) = m_mergeKernel;
			//         m_mergeFinalKernel = (unsigned int)v9.fields.m_mergeFinalKernel;
			//         if ( !v181 )
			//           sub_1802DC2C8(v115, m_mergeFinalKernel);
			//         LODWORD(v181[5].klass) = m_mergeFinalKernel;
			//         m_particleIndirectArgsKernel = (unsigned int)v9.fields.m_particleIndirectArgsKernel;
			//         if ( !v181 )
			//           sub_1802DC2C8(v115, m_particleIndirectArgsKernel);
			//         HIDWORD(v181[5].klass) = m_particleIndirectArgsKernel;
			//         v148 = v181;
			//         if ( !v181 )
			//           sub_1802DC2C8(v115, 0LL);
			//         v181[7].monitor = (MonitorData *)v9.fields.m_senderSimulateList;
			//         if ( (_DWORD)v115 )
			//         {
			//           v149 = ((unsigned __int64)&v148[7].monitor >> 12) & 0x1FFFFF;
			//           v150 = v149 >> 6;
			//           v151 = v149 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v150 + 36190]);
			//           do
			//             v152 = qword_18D6405E0[v150 + 36190];
			//           while ( v152 != _InterlockedCompareExchange64(&qword_18D6405E0[v150 + 36190], v152 | (1LL << v151), v152) );
			//           v115 = (unsigned int)dword_18D8E43F8;
			//         }
			//         v153 = v181;
			//         if ( !v181 )
			//           sub_1802DC2C8(v115, 0LL);
			//         v181[8].klass = (Object__Class *)v9.fields.m_simulateList;
			//         if ( (_DWORD)v115 )
			//         {
			//           v154 = ((unsigned __int64)&v153[8] >> 12) & 0x1FFFFF;
			//           v155 = v154 >> 6;
			//           v156 = v154 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v155 + 36190]);
			//           do
			//             v157 = qword_18D6405E0[v155 + 36190];
			//           while ( v157 != _InterlockedCompareExchange64(&qword_18D6405E0[v155 + 36190], v157 | (1LL << v156), v157) );
			//           v115 = (unsigned int)dword_18D8E43F8;
			//         }
			//         v158 = v181;
			//         if ( !v181 )
			//           sub_1802DC2C8(v115, 0LL);
			//         v181[7].klass = (Object__Class *)camera;
			//         if ( (_DWORD)v115 )
			//         {
			//           v159 = ((unsigned __int64)&v158[7] >> 12) & 0x1FFFFF;
			//           v160 = v159 >> 6;
			//           v161 = v159 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v160 + 36190]);
			//           do
			//             v162 = qword_18D6405E0[v160 + 36190];
			//           while ( v162 != _InterlockedCompareExchange64(&qword_18D6405E0[v160 + 36190], v162 | (1LL << v161), v162) );
			//           v115 = (unsigned int)dword_18D8E43F8;
			//         }
			//         v163 = v181;
			//         v164 = *(MonitorData **)&v9.fields.m_senderKeyword.m_Index;
			//         if ( !v181 )
			//           sub_1802DC2C8(v115, 0LL);
			//         *(Object *)((char *)v181 + 136) = *(Object *)&v9.fields.m_senderKeyword.m_SpaceInfo.m_KeywordSpace;
			//         v163[9].monitor = v164;
			//         if ( (_DWORD)v115 )
			//         {
			//           v165 = ((unsigned __int64)&v163[9] >> 12) & 0x1FFFFF;
			//           v166 = v165 >> 6;
			//           v167 = v165 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v166 + 36190]);
			//           do
			//             v168 = qword_18D6405E0[v166 + 36190];
			//           while ( v168 != _InterlockedCompareExchange64(&qword_18D6405E0[v166 + 36190], v168 | (1LL << v167), v168) );
			//           v115 = (unsigned int)dword_18D8E43F8;
			//         }
			//         v169 = v181;
			//         v170 = *(Object__Class **)&v9.fields.m_recieverKeyword.m_Index;
			//         if ( !v181 )
			//           sub_1802DC2C8(v115, 0LL);
			//         v181[10] = *(Object *)&v9.fields.m_recieverKeyword.m_SpaceInfo.m_KeywordSpace;
			//         v169[11].klass = v170;
			//         if ( (_DWORD)v115 )
			//         {
			//           v171 = ((unsigned __int64)&v169[10].monitor >> 12) & 0x1FFFFF;
			//           v172 = v171 >> 6;
			//           v173 = v171 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v172 + 36190]);
			//           do
			//             v174 = qword_18D6405E0[v172 + 36190];
			//           while ( v174 != _InterlockedCompareExchange64(&qword_18D6405E0[v172 + 36190], v174 | (1LL << v173), v174) );
			//         }
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::GPUParticleSimulationPassConstructor);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v195,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::GPUParticleSimulationPassConstructor.static_fields.s_renderFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::PassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v203 )
			//       {
			//         v194[0] = v203.ex;
			//       }
			//       sub_180222690(v194);
			//     }
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         GPUParticleSimulationPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2680, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2680, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph renderGraph)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
			// void HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         GPUParticleSimulationPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2681, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2681, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)renderGraph,
			//       0LL);
			//   }
			// }
			// 
		}

		private const uint SORT_BATCH_SIZE = 4096U;

		private DynamicArray<GPUParticleSimulationPassConstructor.SimulateRequiredResources> m_simulateList;

		private DynamicArray<GPUParticleSimulationPassConstructor.SimulateRequiredResources> m_senderSimulateList;

		private Dictionary<Guid, int> m_gpuEventDict;

		private List<int> m_receivers;

		private ComputeShader m_particleCleanupShader;

		private ComputeShader m_particleInitShader;

		private ComputeShader m_particleCullShader;

		private ComputeShader m_particleSortShader;

		private ComputeShader m_particleIndirectArgsShader;

		private int m_particleCleanupKernel;

		private int m_particleInitKernel;

		private int m_particleCullKernel;

		private int m_bitonicSortKernel;

		private int m_bitonicSortFinalKernel;

		private int m_mergeKernel;

		private int m_mergeFinalKernel;

		private int m_particleIndirectArgsKernel;

		private LocalKeyword m_senderKeyword;

		private LocalKeyword m_recieverKeyword;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<GPUParticleSimulationPassConstructor.DepthOnlyPassData> s_occlusionRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly RenderFunc<GPUParticleSimulationPassConstructor.PassData> s_renderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 32)]
		internal struct PassInput
		{
			internal TextureHandle sceneDepth;

			internal TextureHandle sceneNormal;
		}

		internal struct PassOutput
		{
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 8)]
		private struct MergePassConstants
		{
			internal uint blockSize;

			internal uint groupCount;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 8)]
		private struct SortKey
		{
			internal uint particleIndex;

			internal float cameraSpaceDepth;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 4)]
		private struct PerFrameBuffer
		{
			internal uint seed;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 12)]
		private struct BufferMapping
		{
			internal int shaderID;

			internal ComputeBufferHandle buffer;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 20)]
		private struct TextureMapping
		{
			internal int shaderID;

			internal TextureHandle texture;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 40)]
		private struct GPUEventData
		{
			internal ComputeBufferHandle eventBuffer;

			internal ComputeBufferHandle sentCountBuffer;

			internal ComputeBufferHandle comsumedCountBuffer;

			internal Guid guid;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		private struct SimulateRequiredResources
		{
			internal void MarkResourceRead(HGRenderGraphBuilder builder)
			{
				// // Void MarkResourceRead(HGRenderGraphBuilder)
				// void HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources::MarkResourceRead(
				//         GPUParticleSimulationPassConstructor_SimulateRequiredResources *this,
				//         HGRenderGraphBuilder *builder,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v6; // rdx
				//   __int64 v7; // rcx
				//   __int128 v8; // xmm1
				//   HGRenderGraphBuilder v9; // [rsp+20h] [rbp-28h] BYREF
				// 
				//   if ( !byte_18D91956F )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
				//     byte_18D91956F = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(2679, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2679, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v7, v6);
				//     v8 = *(_OWORD *)&builder.m_RenderGraph;
				//     *(_OWORD *)&v9.m_RenderPass = *(_OWORD *)&builder.m_RenderPass;
				//     *(_OWORD *)&v9.m_RenderGraph = v8;
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_980(Patch, this, &v9, 0LL);
				//   }
				//   else
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
				//     if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this.depthOnlyRT.texture, 0LL) )
				//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
				//         (TextureHandle *)&v9,
				//         builder,
				//         &this.depthOnlyRT.texture,
				//         0LL);
				//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
				//     if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this.sceneDepth.texture, 0LL) )
				//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
				//         (TextureHandle *)&v9,
				//         builder,
				//         &this.sceneDepth.texture,
				//         0LL);
				//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
				//     if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this.sceneNormal.texture, 0LL) )
				//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
				//         (TextureHandle *)&v9,
				//         builder,
				//         &this.sceneNormal.texture,
				//         0LL);
				//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
				//     if ( HG::Rendering::RenderGraphModule::ComputeBufferHandle::IsValid(&this.gpuEventData.eventBuffer, 0LL) )
				//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteComputeBuffer(
				//         builder,
				//         &this.gpuEventData.eventBuffer,
				//         0LL);
				//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
				//     if ( HG::Rendering::RenderGraphModule::ComputeBufferHandle::IsValid(&this.gpuEventData.sentCountBuffer, 0LL) )
				//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteComputeBuffer(
				//         builder,
				//         &this.gpuEventData.sentCountBuffer,
				//         0LL);
				//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
				//     if ( HG::Rendering::RenderGraphModule::ComputeBufferHandle::IsValid(&this.gpuEventData.comsumedCountBuffer, 0LL) )
				//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteComputeBuffer(
				//         builder,
				//         &this.gpuEventData.comsumedCountBuffer,
				//         0LL);
				//   }
				// }
				// 
			}

			internal GPUParticleSystemBase gpuParticleSystem;

			internal GPUParticleSimulationPassConstructor.TextureMapping depthOnlyRT;

			internal GPUParticleSimulationPassConstructor.TextureMapping sceneDepth;

			internal GPUParticleSimulationPassConstructor.TextureMapping sceneNormal;

			internal GPUParticleSimulationPassConstructor.GPUEventData gpuEventData;
		}

		private class DepthOnlyPassData
		{
			public DepthOnlyPassData()
			{
				// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
				// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
				//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
				//         HGWindConfig *cSrc,
				//         HGWindConfig *cDst,
				//         float t,
				//         MethodInfo *method)
				// {
				//   ;
				// }
				// 
			}

			internal Matrix4x4 deviceViewProj;

			internal Matrix4x4 cullingViewProj;

			internal uint ecsRendererList;
		}

		private class PassData
		{
			public PassData()
			{
				// // GPUParticleSimulationPassConstructor+PassData()
				// void HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::PassData::PassData(
				//         GPUParticleSimulationPassConstructor_PassData *this,
				//         MethodInfo *method)
				// {
				//   __int64 v2; // r8
				//   __int64 v3; // r9
				//   OneofDescriptorProto *v5; // rdx
				//   FileDescriptor *v6; // r8
				//   MessageDescriptor *v7; // r9
				//   String__Array *v8; // [rsp+50h] [rbp+28h]
				//   String *v9; // [rsp+58h] [rbp+30h]
				//   MethodInfo *v10; // [rsp+60h] [rbp+38h]
				// 
				//   if ( !byte_18D919570 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
				//     byte_18D919570 = 1;
				//   }
				//   this.fields.stagingLiveListBuffers = (ComputeBufferHandle__Array *)il2cpp_array_new_specific_0(
				//                                                                         TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle,
				//                                                                         2LL,
				//                                                                         v2,
				//                                                                         v3);
				//   sub_1800054D0((OneofDescriptor *)&this.fields.stagingLiveListBuffers, v5, v6, v7, v8, v9, v10);
				// }
				// 
			}

			internal ComputeShader particleCleanupShader;

			internal ComputeShader particleInitShader;

			internal ComputeShader particleCullShader;

			internal ComputeShader particleSortShader;

			internal ComputeShader particleIndirectArgsShader;

			internal int particleCleanupKernel;

			internal int particleInitKernel;

			internal int particleCullKernel;

			internal int bitonicSortKernel;

			internal int bitonicSortFinalKernel;

			internal int mergeKernel;

			internal int mergeFinalKernel;

			internal int particleIndirectArgsKernel;

			internal ComputeBufferHandle[] stagingLiveListBuffers;

			internal ComputeBufferHandle dataForEmitterBuffer;

			internal ComputeBufferHandle liveCountBuffer;

			internal HGCamera camera;

			internal DynamicArray<GPUParticleSimulationPassConstructor.SimulateRequiredResources> senderSimulateList;

			internal DynamicArray<GPUParticleSimulationPassConstructor.SimulateRequiredResources> simulateList;

			internal LocalKeyword senderKeyword;

			internal LocalKeyword recieverKeyword;
		}
	}
}
