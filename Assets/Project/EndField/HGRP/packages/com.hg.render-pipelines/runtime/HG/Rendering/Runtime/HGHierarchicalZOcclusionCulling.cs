using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGHierarchicalZOcclusionCulling // TypeDefIndex: 37546
	{
		// Fields
		public const int DEPTH_BUFFER_RESOLUTION_X = 256; // Metadata: 0x02302F14
		public const int DEPTH_BUFFER_RESOLUTION_Y = 128; // Metadata: 0x02302F16
		private const int COMPUTE_SHADER_LOCAL_SIZE_X = 16; // Metadata: 0x02302F18
		private const int COMPUTE_SHADER_LOCAL_SIZE_Y = 8; // Metadata: 0x02302F19
		private const int DEPTH_BUFFER_MIP_COUNT = 8; // Metadata: 0x02302F1A
		private const int DEPTH_BUFFER_COUNT = 3; // Metadata: 0x02302F1B
		private const int COMPUTE_SHADER_WORK_GROUP_X = 16; // Metadata: 0x02302F1C
		private const int COMPUTE_SHADER_WORK_GROUP_Y = 16; // Metadata: 0x02302F1D
		private readonly RTHandle[] m_hizDepthMipChains; // 0x10
		private ushort m_frameCounter; // 0x18
		private readonly ComputeShader m_hizDownSampleCS; // 0x20
		private readonly int m_hizDownSampleKernel0; // 0x28
		private readonly int m_hizDownSampleKernel1; // 0x2C
	
		// Properties
		public RTHandle currentDepthMipChain { get => default; } // 0x0000000189C6F4AC-0x0000000189C6F524 
		// RTHandle get_currentDepthMipChain()
		RTHandle *HG::Rendering::Runtime::HGHierarchicalZOcclusionCulling::get_currentDepthMipChain(
		        HGHierarchicalZOcclusionCulling *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  RTHandle__Array *m_hizDepthMipChains; // r8
		  __int64 v6; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(421, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(421, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_128(Patch, (Object *)this, 0LL);
		LABEL_7:
		    sub_1800D8260(v4, v3);
		  }
		  m_hizDepthMipChains = this->fields.m_hizDepthMipChains;
		  if ( !m_hizDepthMipChains )
		    goto LABEL_7;
		  v6 = this->fields.m_frameCounter % 3u;
		  if ( (unsigned int)v6 >= m_hizDepthMipChains->max_length.size )
		    sub_1800D2AB0(v6, this->fields.m_frameCounter / 3u);
		  return m_hizDepthMipChains->vector[(int)v6];
		}
		
	
		// Constructors
		public HGHierarchicalZOcclusionCulling() {} // Dummy constructor
		internal HGHierarchicalZOcclusionCulling(HGRenderPipelineRuntimeResources defaultResources) {} // 0x0000000189C6F310-0x0000000189C6F4AC
		// HGHierarchicalZOcclusionCulling(HGRenderPipelineRuntimeResources)
		void HG::Rendering::Runtime::HGHierarchicalZOcclusionCulling::HGHierarchicalZOcclusionCulling(
		        HGHierarchicalZOcclusionCulling *this,
		        HGRenderPipelineRuntimeResources *defaultResources,
		        MethodInfo *method)
		{
		  Type *v5; // rdx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  Type *v8; // rdx
		  ComputeShader *m_hizDownSampleCS; // rcx
		  PropertyInfo_1 *v10; // r8
		  Int32__Array **v11; // r9
		  int32_t i; // r14d
		  RTHandle__Array *m_hizDepthMipChains; // rax
		  RTHandle__Array *v14; // rdi
		  RTHandle *v15; // rbx
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  int32_t Kernel; // eax
		  MethodInfo *colorFormat; // [rsp+20h] [rbp-A8h]
		  MethodInfo *colorFormata; // [rsp+20h] [rbp-A8h]
		
		  this->fields.m_hizDepthMipChains = (RTHandle__Array *)il2cpp_array_new_specific_1(
		                                                          TypeInfo::UnityEngine::Rendering::RTHandle,
		                                                          3LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v5, v6, v7, colorFormat);
		  for ( i = 0; ; ++i )
		  {
		    m_hizDepthMipChains = this->fields.m_hizDepthMipChains;
		    if ( !m_hizDepthMipChains )
		      goto LABEL_10;
		    if ( i >= m_hizDepthMipChains->max_length.size )
		      break;
		    v14 = this->fields.m_hizDepthMipChains;
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::RTHandles);
		    v15 = UnityEngine::Rendering::RTHandles::Alloc(
		            256,
		            128,
		            1,
		            DepthBits__Enum_None,
		            GraphicsFormat__Enum_R32_SFloat,
		            FilterMode__Enum_Point,
		            TextureWrapMode__Enum_Clamp,
		            TextureDimension__Enum_Tex2D,
		            1,
		            1,
		            0,
		            0,
		            1,
		            0.0,
		            MSAASamples__Enum_None,
		            0,
		            RenderTextureMemoryless__Enum_None,
		            (String *)"",
		            0LL);
		    sub_180031B10(v14, v15);
		    sub_180378FEC(v14, i, v15);
		  }
		  this->fields.m_frameCounter = 0;
		  if ( !defaultResources
		    || (shaders = defaultResources->fields.shaders) == 0LL
		    || (this->fields.m_hizDownSampleCS = shaders->fields.hizDownSampleCS,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_hizDownSampleCS, v8, v10, v11, colorFormata),
		        (m_hizDownSampleCS = this->fields.m_hizDownSampleCS) == 0LL)
		    || (Kernel = UnityEngine::ComputeShader::FindKernel(m_hizDownSampleCS, (String *)"Phase0", 0LL),
		        m_hizDownSampleCS = this->fields.m_hizDownSampleCS,
		        this->fields.m_hizDownSampleKernel0 = Kernel,
		        !m_hizDownSampleCS) )
		  {
		LABEL_10:
		    sub_1800D8260(m_hizDownSampleCS, v8);
		  }
		  this->fields.m_hizDownSampleKernel1 = UnityEngine::ComputeShader::FindKernel(
		                                          m_hizDownSampleCS,
		                                          (String *)"Phase1",
		                                          0LL);
		}
		
	
		// Methods
		public void DownSampleMipmapChainPhase0(TextureHandle currentDepth, CommandBuffer cmd) {} // 0x0000000189C6ECBC-0x0000000189C6EFF4
		// Void DownSampleMipmapChainPhase0(TextureHandle, CommandBuffer)
		void HG::Rendering::Runtime::HGHierarchicalZOcclusionCulling::DownSampleMipmapChainPhase0(
		        HGHierarchicalZOcclusionCulling *this,
		        TextureHandle *currentDepth,
		        CommandBuffer *cmd,
		        MethodInfo *method)
		{
		  ComputeShader *m_hizDownSampleCS; // rdi
		  int32_t m_hizDownSampleKernel0; // esi
		  int32_t HGHiZInput; // r12d
		  RenderTargetIdentifier *v10; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  __int128 v13; // xmm1
		  __int64 v14; // xmm0_8
		  ComputeShader *v15; // rsi
		  int32_t v16; // edi
		  int32_t HGHiZOutput0; // ebx
		  RTHandle *currentDepthMipChain; // rax
		  RenderTargetIdentifier *v19; // rax
		  __int128 v20; // xmm1
		  __int64 v21; // xmm0_8
		  ComputeShader *v22; // rsi
		  int32_t v23; // edi
		  int32_t HGHiZOutput1; // ebx
		  RTHandle *v25; // rax
		  RenderTargetIdentifier *v26; // rax
		  __int128 v27; // xmm1
		  __int64 v28; // xmm0_8
		  ComputeShader *v29; // rsi
		  int32_t v30; // edi
		  int32_t HGHiZOutput2; // ebx
		  RTHandle *v32; // rax
		  RenderTargetIdentifier *v33; // rax
		  __int128 v34; // xmm1
		  __int64 v35; // xmm0_8
		  ComputeShader *v36; // rsi
		  int32_t v37; // edi
		  int32_t HGHiZOutput3; // ebx
		  RTHandle *v39; // rax
		  RenderTargetIdentifier *v40; // rax
		  __int128 v41; // xmm1
		  __int64 v42; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v44; // rdx
		  __int64 v45; // rcx
		  RenderTargetIdentifier v46; // [rsp+48h] [rbp-59h] BYREF
		  TextureHandle v47; // [rsp+78h] [rbp-29h] BYREF
		  RenderTargetIdentifier v48; // [rsp+88h] [rbp-19h] BYREF
		  RenderTargetIdentifier v49; // [rsp+B8h] [rbp+17h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1229, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1229, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v45, v44);
		    v47 = *currentDepth;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_472(Patch, (Object *)this, &v47, (Object *)cmd, 0LL);
		  }
		  else
		  {
		    m_hizDownSampleCS = this->fields.m_hizDownSampleCS;
		    ++this->fields.m_frameCounter;
		    m_hizDownSampleKernel0 = this->fields.m_hizDownSampleKernel0;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    HGHiZInput = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGHiZInput;
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    v47 = *currentDepth;
		    v10 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v48, &v47, 0LL);
		    if ( !cmd )
		      sub_1800D8260(v12, v11);
		    v13 = *(_OWORD *)&v10->m_BufferPointer;
		    *(_OWORD *)&v46.m_Type = *(_OWORD *)&v10->m_Type;
		    v14 = *(_QWORD *)&v10->m_DepthSlice;
		    *(_OWORD *)&v46.m_BufferPointer = v13;
		    *(_QWORD *)&v46.m_DepthSlice = v14;
		    UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
		      cmd,
		      m_hizDownSampleCS,
		      m_hizDownSampleKernel0,
		      HGHiZInput,
		      &v46,
		      0,
		      0LL);
		    v15 = this->fields.m_hizDownSampleCS;
		    v16 = this->fields.m_hizDownSampleKernel0;
		    HGHiZOutput0 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGHiZOutput0;
		    currentDepthMipChain = HG::Rendering::Runtime::HGHierarchicalZOcclusionCulling::get_currentDepthMipChain(this, 0LL);
		    v19 = UnityEngine::Rendering::RTHandle::op_Implicit(&v49, currentDepthMipChain, 0LL);
		    v20 = *(_OWORD *)&v19->m_BufferPointer;
		    *(_OWORD *)&v48.m_Type = *(_OWORD *)&v19->m_Type;
		    v21 = *(_QWORD *)&v19->m_DepthSlice;
		    *(_OWORD *)&v48.m_BufferPointer = v20;
		    *(_QWORD *)&v48.m_DepthSlice = v21;
		    UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(cmd, v15, v16, HGHiZOutput0, &v48, 0, 0LL);
		    v22 = this->fields.m_hizDownSampleCS;
		    v23 = this->fields.m_hizDownSampleKernel0;
		    HGHiZOutput1 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGHiZOutput1;
		    v25 = HG::Rendering::Runtime::HGHierarchicalZOcclusionCulling::get_currentDepthMipChain(this, 0LL);
		    v26 = UnityEngine::Rendering::RTHandle::op_Implicit(&v49, v25, 0LL);
		    v27 = *(_OWORD *)&v26->m_BufferPointer;
		    *(_OWORD *)&v46.m_Type = *(_OWORD *)&v26->m_Type;
		    v28 = *(_QWORD *)&v26->m_DepthSlice;
		    *(_OWORD *)&v46.m_BufferPointer = v27;
		    *(_QWORD *)&v46.m_DepthSlice = v28;
		    UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(cmd, v22, v23, HGHiZOutput1, &v46, 1, 0LL);
		    v29 = this->fields.m_hizDownSampleCS;
		    v30 = this->fields.m_hizDownSampleKernel0;
		    HGHiZOutput2 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGHiZOutput2;
		    v32 = HG::Rendering::Runtime::HGHierarchicalZOcclusionCulling::get_currentDepthMipChain(this, 0LL);
		    v33 = UnityEngine::Rendering::RTHandle::op_Implicit(&v49, v32, 0LL);
		    v34 = *(_OWORD *)&v33->m_BufferPointer;
		    *(_OWORD *)&v48.m_Type = *(_OWORD *)&v33->m_Type;
		    v35 = *(_QWORD *)&v33->m_DepthSlice;
		    *(_OWORD *)&v48.m_BufferPointer = v34;
		    *(_QWORD *)&v48.m_DepthSlice = v35;
		    UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(cmd, v29, v30, HGHiZOutput2, &v48, 2, 0LL);
		    v36 = this->fields.m_hizDownSampleCS;
		    v37 = this->fields.m_hizDownSampleKernel0;
		    HGHiZOutput3 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGHiZOutput3;
		    v39 = HG::Rendering::Runtime::HGHierarchicalZOcclusionCulling::get_currentDepthMipChain(this, 0LL);
		    v40 = UnityEngine::Rendering::RTHandle::op_Implicit(&v49, v39, 0LL);
		    v41 = *(_OWORD *)&v40->m_BufferPointer;
		    *(_OWORD *)&v46.m_Type = *(_OWORD *)&v40->m_Type;
		    v42 = *(_QWORD *)&v40->m_DepthSlice;
		    *(_OWORD *)&v46.m_BufferPointer = v41;
		    *(_QWORD *)&v46.m_DepthSlice = v42;
		    UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(cmd, v36, v37, HGHiZOutput3, &v46, 3, 0LL);
		    UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
		      cmd,
		      this->fields.m_hizDownSampleCS,
		      this->fields.m_hizDownSampleKernel0,
		      16,
		      16,
		      1,
		      0LL);
		  }
		}
		
		public void DownSampleMipmapChainPhase1(CommandBuffer cmd) {} // 0x0000000189C6EFF4-0x0000000189C6F310
		// Void DownSampleMipmapChainPhase1(CommandBuffer)
		void HG::Rendering::Runtime::HGHierarchicalZOcclusionCulling::DownSampleMipmapChainPhase1(
		        HGHierarchicalZOcclusionCulling *this,
		        CommandBuffer *cmd,
		        MethodInfo *method)
		{
		  ComputeShader *m_hizDownSampleCS; // rbx
		  int32_t m_hizDownSampleKernel1; // edi
		  int32_t HGHiZInput; // esi
		  RTHandle *currentDepthMipChain; // rax
		  RenderTargetIdentifier *v9; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  __int128 v12; // xmm1
		  __int64 v13; // xmm0_8
		  ComputeShader *v14; // rsi
		  int32_t v15; // edi
		  int32_t HGHiZOutput0; // ebx
		  RTHandle *v17; // rax
		  RenderTargetIdentifier *v18; // rax
		  __int128 v19; // xmm1
		  __int64 v20; // xmm0_8
		  ComputeShader *v21; // rsi
		  int32_t v22; // edi
		  int32_t HGHiZOutput1; // ebx
		  RTHandle *v24; // rax
		  RenderTargetIdentifier *v25; // rax
		  __int128 v26; // xmm1
		  __int64 v27; // xmm0_8
		  ComputeShader *v28; // rsi
		  int32_t v29; // edi
		  int32_t HGHiZOutput2; // ebx
		  RTHandle *v31; // rax
		  RenderTargetIdentifier *v32; // rax
		  __int128 v33; // xmm1
		  __int64 v34; // xmm0_8
		  ComputeShader *v35; // rsi
		  int32_t v36; // edi
		  int32_t HGHiZOutput3; // ebx
		  RTHandle *v38; // rax
		  RenderTargetIdentifier *v39; // rax
		  __int128 v40; // xmm1
		  __int64 v41; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v43; // rdx
		  __int64 v44; // rcx
		  RenderTargetIdentifier v45; // [rsp+48h] [rbp-49h] BYREF
		  RenderTargetIdentifier v46; // [rsp+78h] [rbp-19h] BYREF
		  RenderTargetIdentifier v47; // [rsp+A8h] [rbp+17h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(420, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(420, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v44, v43);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)cmd,
		      0LL);
		  }
		  else if ( this->fields.m_frameCounter )
		  {
		    m_hizDownSampleCS = this->fields.m_hizDownSampleCS;
		    m_hizDownSampleKernel1 = this->fields.m_hizDownSampleKernel1;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    HGHiZInput = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGHiZInput;
		    currentDepthMipChain = HG::Rendering::Runtime::HGHierarchicalZOcclusionCulling::get_currentDepthMipChain(this, 0LL);
		    v9 = UnityEngine::Rendering::RTHandle::op_Implicit(&v46, currentDepthMipChain, 0LL);
		    if ( !cmd )
		      sub_1800D8260(v11, v10);
		    v12 = *(_OWORD *)&v9->m_BufferPointer;
		    *(_OWORD *)&v45.m_Type = *(_OWORD *)&v9->m_Type;
		    v13 = *(_QWORD *)&v9->m_DepthSlice;
		    *(_OWORD *)&v45.m_BufferPointer = v12;
		    *(_QWORD *)&v45.m_DepthSlice = v13;
		    UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
		      cmd,
		      m_hizDownSampleCS,
		      m_hizDownSampleKernel1,
		      HGHiZInput,
		      &v45,
		      3,
		      0LL);
		    v14 = this->fields.m_hizDownSampleCS;
		    v15 = this->fields.m_hizDownSampleKernel1;
		    HGHiZOutput0 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGHiZOutput0;
		    v17 = HG::Rendering::Runtime::HGHierarchicalZOcclusionCulling::get_currentDepthMipChain(this, 0LL);
		    v18 = UnityEngine::Rendering::RTHandle::op_Implicit(&v47, v17, 0LL);
		    v19 = *(_OWORD *)&v18->m_BufferPointer;
		    *(_OWORD *)&v46.m_Type = *(_OWORD *)&v18->m_Type;
		    v20 = *(_QWORD *)&v18->m_DepthSlice;
		    *(_OWORD *)&v46.m_BufferPointer = v19;
		    *(_QWORD *)&v46.m_DepthSlice = v20;
		    UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(cmd, v14, v15, HGHiZOutput0, &v46, 4, 0LL);
		    v21 = this->fields.m_hizDownSampleCS;
		    v22 = this->fields.m_hizDownSampleKernel1;
		    HGHiZOutput1 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGHiZOutput1;
		    v24 = HG::Rendering::Runtime::HGHierarchicalZOcclusionCulling::get_currentDepthMipChain(this, 0LL);
		    v25 = UnityEngine::Rendering::RTHandle::op_Implicit(&v47, v24, 0LL);
		    v26 = *(_OWORD *)&v25->m_BufferPointer;
		    *(_OWORD *)&v45.m_Type = *(_OWORD *)&v25->m_Type;
		    v27 = *(_QWORD *)&v25->m_DepthSlice;
		    *(_OWORD *)&v45.m_BufferPointer = v26;
		    *(_QWORD *)&v45.m_DepthSlice = v27;
		    UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(cmd, v21, v22, HGHiZOutput1, &v45, 5, 0LL);
		    v28 = this->fields.m_hizDownSampleCS;
		    v29 = this->fields.m_hizDownSampleKernel1;
		    HGHiZOutput2 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGHiZOutput2;
		    v31 = HG::Rendering::Runtime::HGHierarchicalZOcclusionCulling::get_currentDepthMipChain(this, 0LL);
		    v32 = UnityEngine::Rendering::RTHandle::op_Implicit(&v47, v31, 0LL);
		    v33 = *(_OWORD *)&v32->m_BufferPointer;
		    *(_OWORD *)&v46.m_Type = *(_OWORD *)&v32->m_Type;
		    v34 = *(_QWORD *)&v32->m_DepthSlice;
		    *(_OWORD *)&v46.m_BufferPointer = v33;
		    *(_QWORD *)&v46.m_DepthSlice = v34;
		    UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(cmd, v28, v29, HGHiZOutput2, &v46, 6, 0LL);
		    v35 = this->fields.m_hizDownSampleCS;
		    v36 = this->fields.m_hizDownSampleKernel1;
		    HGHiZOutput3 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGHiZOutput3;
		    v38 = HG::Rendering::Runtime::HGHierarchicalZOcclusionCulling::get_currentDepthMipChain(this, 0LL);
		    v39 = UnityEngine::Rendering::RTHandle::op_Implicit(&v47, v38, 0LL);
		    v40 = *(_OWORD *)&v39->m_BufferPointer;
		    *(_OWORD *)&v45.m_Type = *(_OWORD *)&v39->m_Type;
		    v41 = *(_QWORD *)&v39->m_DepthSlice;
		    *(_OWORD *)&v45.m_BufferPointer = v40;
		    *(_QWORD *)&v45.m_DepthSlice = v41;
		    UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(cmd, v35, v36, HGHiZOutput3, &v45, 7, 0LL);
		    UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
		      cmd,
		      this->fields.m_hizDownSampleCS,
		      this->fields.m_hizDownSampleKernel1,
		      1,
		      1,
		      1,
		      0LL);
		  }
		}
		
		public void AddQuery() {} // 0x0000000189C6EBFC-0x0000000189C6EC40
		// Void AddQuery()
		void HG::Rendering::Runtime::HGHierarchicalZOcclusionCulling::AddQuery(
		        HGHierarchicalZOcclusionCulling *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1230, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1230, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		}
		
		public void Dispose() {} // 0x0000000189C6EC40-0x0000000189C6ECBC
		// Void Dispose()
		void HG::Rendering::Runtime::HGHierarchicalZOcclusionCulling::Dispose(
		        HGHierarchicalZOcclusionCulling *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  RTHandle *v4; // rcx
		  RTHandle__Array *m_hizDepthMipChains; // rdi
		  int32_t v6; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(423, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(423, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		LABEL_9:
		    sub_1800D8260(v4, v3);
		  }
		  m_hizDepthMipChains = this->fields.m_hizDepthMipChains;
		  v6 = 0;
		  if ( !m_hizDepthMipChains )
		    goto LABEL_9;
		  while ( v6 < m_hizDepthMipChains->max_length.size )
		  {
		    if ( (unsigned int)v6 >= m_hizDepthMipChains->max_length.size )
		      sub_1800D2AB0(v4, v3);
		    v4 = m_hizDepthMipChains->vector[v6];
		    if ( !v4 )
		      goto LABEL_9;
		    UnityEngine::Rendering::RTHandle::Release(v4, 0LL);
		    ++v6;
		  }
		}
		
	}
}
