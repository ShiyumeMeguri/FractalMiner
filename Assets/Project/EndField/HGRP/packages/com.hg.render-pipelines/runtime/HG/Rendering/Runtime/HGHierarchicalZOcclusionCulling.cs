using System;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class HGHierarchicalZOcclusionCulling
	{
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x000025D2 File Offset: 0x000007D2
		public RTHandle currentDepthMipChain
		{
			get
			{
				// // RTHandle get_currentDepthMipChain()
				// RTHandle *HG::Rendering::Runtime::HGHierarchicalZOcclusionCulling::get_currentDepthMipChain(
				//         HGHierarchicalZOcclusionCulling *this,
				//         MethodInfo *method)
				// {
				//   RTHandle__Array *m_hizDepthMipChains; // r8
				//   unsigned int m_frameCounter; // eax
				//   __int64 v4; // rcx
				// 
				//   m_hizDepthMipChains = this.fields.m_hizDepthMipChains;
				//   m_frameCounter = this.fields.m_frameCounter;
				//   if ( !m_hizDepthMipChains )
				//     sub_180B536AC(this, method);
				//   v4 = m_frameCounter % 3;
				//   if ( (unsigned int)v4 >= m_hizDepthMipChains.max_length.size )
				//     sub_180070270(v4, m_frameCounter / 3);
				//   return m_hizDepthMipChains.vector[(int)v4];
				// }
				// 
				return null;
			}
		}

		internal HGHierarchicalZOcclusionCulling(HGRenderPipelineRuntimeResources defaultResources)
		{
			// // HGHierarchicalZOcclusionCulling(HGRenderPipelineRuntimeResources)
			// void HG::Rendering::Runtime::HGHierarchicalZOcclusionCulling::HGHierarchicalZOcclusionCulling(
			//         HGHierarchicalZOcclusionCulling *this,
			//         HGRenderPipelineRuntimeResources *defaultResources,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // r9
			//   OneofDescriptorProto *v6; // rdx
			//   FileDescriptor *v7; // r8
			//   MessageDescriptor *v8; // r9
			//   OneofDescriptorProto *v9; // rdx
			//   ComputeShader *m_hizDownSampleCS; // rcx
			//   FileDescriptor *v11; // r8
			//   MessageDescriptor *v12; // r9
			//   int32_t i; // r14d
			//   RTHandle__Array *m_hizDepthMipChains; // rax
			//   RTHandle__Array *v15; // rdi
			//   RTHandle *v16; // rbx
			//   HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
			//   int32_t Kernel; // eax
			//   String__Array *colorFormat; // [rsp+20h] [rbp-A8h]
			//   String__Array *colorFormata; // [rsp+20h] [rbp-A8h]
			//   String *filterMode; // [rsp+28h] [rbp-A0h]
			//   String *filterModea; // [rsp+28h] [rbp-A0h]
			//   MethodInfo *wrapMode; // [rsp+30h] [rbp-98h]
			//   MethodInfo *wrapModea; // [rsp+30h] [rbp-98h]
			// 
			//   if ( !byte_18D919CD4 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RTHandle);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RTHandles);
			//     sub_18003C530(&off_18D532AB8);
			//     sub_18003C530(&off_18D532AC0);
			//     sub_18003C530(&off_18C9B4D38);
			//     byte_18D919CD4 = 1;
			//   }
			//   this.fields.m_hizDepthMipChains = (RTHandle__Array *)il2cpp_array_new_specific_0(
			//                                                           TypeInfo::UnityEngine::Rendering::RTHandle,
			//                                                           3LL,
			//                                                           method,
			//                                                           v3);
			//   sub_1800054D0((OneofDescriptor *)&this.fields, v6, v7, v8, colorFormat, filterMode, wrapMode);
			//   for ( i = 0; ; ++i )
			//   {
			//     m_hizDepthMipChains = this.fields.m_hizDepthMipChains;
			//     if ( !m_hizDepthMipChains )
			//       goto LABEL_12;
			//     if ( i >= m_hizDepthMipChains.max_length.size )
			//       break;
			//     v15 = this.fields.m_hizDepthMipChains;
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::RTHandles);
			//     v16 = UnityEngine::Rendering::RTHandles::Alloc(
			//             256,
			//             128,
			//             1,
			//             DepthBits__Enum_None,
			//             GraphicsFormat__Enum_R32_SFloat,
			//             FilterMode__Enum_Point,
			//             TextureWrapMode__Enum_Clamp,
			//             TextureDimension__Enum_Tex2D,
			//             1,
			//             1,
			//             0,
			//             0,
			//             1,
			//             0.0,
			//             MSAASamples__Enum_None,
			//             0,
			//             RenderTextureMemoryless__Enum_None,
			//             (String *)"",
			//             0LL);
			//     sub_180036D40(v15, v16);
			//     sub_180328478(v15, i, v16);
			//   }
			//   this.fields.m_frameCounter = 0;
			//   if ( !defaultResources
			//     || (shaders = defaultResources.fields.shaders) == 0LL
			//     || (this.fields.m_hizDownSampleCS = shaders.fields.hizDownSampleCS,
			//         sub_1800054D0(
			//           (OneofDescriptor *)&this.fields.m_hizDownSampleCS,
			//           v9,
			//           v11,
			//           v12,
			//           colorFormata,
			//           filterModea,
			//           wrapModea),
			//         (m_hizDownSampleCS = this.fields.m_hizDownSampleCS) == 0LL)
			//     || (Kernel = UnityEngine::ComputeShader::FindKernel(m_hizDownSampleCS, (String *)"Phase0", 0LL),
			//         m_hizDownSampleCS = this.fields.m_hizDownSampleCS,
			//         this.fields.m_hizDownSampleKernel0 = Kernel,
			//         !m_hizDownSampleCS) )
			//   {
			// LABEL_12:
			//     sub_180B536AC(m_hizDownSampleCS, v9);
			//   }
			//   this.fields.m_hizDownSampleKernel1 = UnityEngine::ComputeShader::FindKernel(
			//                                           m_hizDownSampleCS,
			//                                           (String *)"Phase1",
			//                                           0LL);
			// }
			// 
		}

		public void DownSampleMipmapChainPhase0(TextureHandle currentDepth, CommandBuffer cmd)
		{
			// // Void DownSampleMipmapChainPhase0(TextureHandle, CommandBuffer)
			// void HG::Rendering::Runtime::HGHierarchicalZOcclusionCulling::DownSampleMipmapChainPhase0(
			//         HGHierarchicalZOcclusionCulling *this,
			//         TextureHandle *currentDepth,
			//         CommandBuffer *cmd,
			//         MethodInfo *method)
			// {
			//   ComputeShader *m_hizDownSampleCS; // rdi
			//   int32_t m_hizDownSampleKernel0; // esi
			//   int32_t HGHiZInput; // r12d
			//   RenderTargetIdentifier *v10; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   __int128 v13; // xmm1
			//   __int64 v14; // xmm0_8
			//   ComputeShader *v15; // rsi
			//   int32_t v16; // edi
			//   int32_t HGHiZOutput0; // ebx
			//   RTHandle *currentDepthMipChain; // rax
			//   RenderTargetIdentifier *v19; // rax
			//   __int128 v20; // xmm1
			//   __int64 v21; // xmm0_8
			//   ComputeShader *v22; // rsi
			//   int32_t v23; // edi
			//   int32_t HGHiZOutput1; // ebx
			//   RTHandle *v25; // rax
			//   RenderTargetIdentifier *v26; // rax
			//   __int128 v27; // xmm1
			//   __int64 v28; // xmm0_8
			//   ComputeShader *v29; // rsi
			//   int32_t v30; // edi
			//   int32_t HGHiZOutput2; // ebx
			//   RTHandle *v32; // rax
			//   RenderTargetIdentifier *v33; // rax
			//   __int128 v34; // xmm1
			//   __int64 v35; // xmm0_8
			//   ComputeShader *v36; // rsi
			//   int32_t v37; // edi
			//   int32_t HGHiZOutput3; // ebx
			//   RTHandle *v39; // rax
			//   RenderTargetIdentifier *v40; // rax
			//   __int128 v41; // xmm1
			//   __int64 v42; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v44; // rdx
			//   __int64 v45; // rcx
			//   RenderTargetIdentifier v46; // [rsp+48h] [rbp-59h] BYREF
			//   TextureHandle v47; // [rsp+78h] [rbp-29h] BYREF
			//   RenderTargetIdentifier v48; // [rsp+88h] [rbp-19h] BYREF
			//   RenderTargetIdentifier v49; // [rsp+B8h] [rbp+17h] BYREF
			// 
			//   if ( !byte_18D919CD5 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D919CD5 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1102, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1102, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v45, v44);
			//     v47 = *currentDepth;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_404(Patch, (Object *)this, &v47, (Object *)cmd, 0LL);
			//   }
			//   else
			//   {
			//     ++this.fields.m_frameCounter;
			//     m_hizDownSampleCS = this.fields.m_hizDownSampleCS;
			//     m_hizDownSampleKernel0 = this.fields.m_hizDownSampleKernel0;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     HGHiZInput = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGHiZInput;
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     v47 = *currentDepth;
			//     v10 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v48, &v47, 0LL);
			//     if ( !cmd )
			//       sub_180B536AC(v12, v11);
			//     v13 = *(_OWORD *)&v10.m_BufferPointer;
			//     *(_OWORD *)&v46.m_Type = *(_OWORD *)&v10.m_Type;
			//     v14 = *(_QWORD *)&v10.m_DepthSlice;
			//     *(_OWORD *)&v46.m_BufferPointer = v13;
			//     *(_QWORD *)&v46.m_DepthSlice = v14;
			//     UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
			//       cmd,
			//       m_hizDownSampleCS,
			//       m_hizDownSampleKernel0,
			//       HGHiZInput,
			//       &v46,
			//       0,
			//       0LL);
			//     v15 = this.fields.m_hizDownSampleCS;
			//     v16 = this.fields.m_hizDownSampleKernel0;
			//     HGHiZOutput0 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGHiZOutput0;
			//     currentDepthMipChain = HG::Rendering::Runtime::HGHierarchicalZOcclusionCulling::get_currentDepthMipChain(this, 0LL);
			//     v19 = UnityEngine::Rendering::RTHandle::op_Implicit(&v49, currentDepthMipChain, 0LL);
			//     v20 = *(_OWORD *)&v19.m_BufferPointer;
			//     *(_OWORD *)&v48.m_Type = *(_OWORD *)&v19.m_Type;
			//     v21 = *(_QWORD *)&v19.m_DepthSlice;
			//     *(_OWORD *)&v48.m_BufferPointer = v20;
			//     *(_QWORD *)&v48.m_DepthSlice = v21;
			//     UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(cmd, v15, v16, HGHiZOutput0, &v48, 0, 0LL);
			//     v22 = this.fields.m_hizDownSampleCS;
			//     v23 = this.fields.m_hizDownSampleKernel0;
			//     HGHiZOutput1 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGHiZOutput1;
			//     v25 = HG::Rendering::Runtime::HGHierarchicalZOcclusionCulling::get_currentDepthMipChain(this, 0LL);
			//     v26 = UnityEngine::Rendering::RTHandle::op_Implicit(&v49, v25, 0LL);
			//     v27 = *(_OWORD *)&v26.m_BufferPointer;
			//     *(_OWORD *)&v46.m_Type = *(_OWORD *)&v26.m_Type;
			//     v28 = *(_QWORD *)&v26.m_DepthSlice;
			//     *(_OWORD *)&v46.m_BufferPointer = v27;
			//     *(_QWORD *)&v46.m_DepthSlice = v28;
			//     UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(cmd, v22, v23, HGHiZOutput1, &v46, 1, 0LL);
			//     v29 = this.fields.m_hizDownSampleCS;
			//     v30 = this.fields.m_hizDownSampleKernel0;
			//     HGHiZOutput2 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGHiZOutput2;
			//     v32 = HG::Rendering::Runtime::HGHierarchicalZOcclusionCulling::get_currentDepthMipChain(this, 0LL);
			//     v33 = UnityEngine::Rendering::RTHandle::op_Implicit(&v49, v32, 0LL);
			//     v34 = *(_OWORD *)&v33.m_BufferPointer;
			//     *(_OWORD *)&v48.m_Type = *(_OWORD *)&v33.m_Type;
			//     v35 = *(_QWORD *)&v33.m_DepthSlice;
			//     *(_OWORD *)&v48.m_BufferPointer = v34;
			//     *(_QWORD *)&v48.m_DepthSlice = v35;
			//     UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(cmd, v29, v30, HGHiZOutput2, &v48, 2, 0LL);
			//     v36 = this.fields.m_hizDownSampleCS;
			//     v37 = this.fields.m_hizDownSampleKernel0;
			//     HGHiZOutput3 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGHiZOutput3;
			//     v39 = HG::Rendering::Runtime::HGHierarchicalZOcclusionCulling::get_currentDepthMipChain(this, 0LL);
			//     v40 = UnityEngine::Rendering::RTHandle::op_Implicit(&v49, v39, 0LL);
			//     v41 = *(_OWORD *)&v40.m_BufferPointer;
			//     *(_OWORD *)&v46.m_Type = *(_OWORD *)&v40.m_Type;
			//     v42 = *(_QWORD *)&v40.m_DepthSlice;
			//     *(_OWORD *)&v46.m_BufferPointer = v41;
			//     *(_QWORD *)&v46.m_DepthSlice = v42;
			//     UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(cmd, v36, v37, HGHiZOutput3, &v46, 3, 0LL);
			//     UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
			//       cmd,
			//       this.fields.m_hizDownSampleCS,
			//       this.fields.m_hizDownSampleKernel0,
			//       16,
			//       16,
			//       1,
			//       0LL);
			//   }
			// }
			// 
		}

		public void DownSampleMipmapChainPhase1(CommandBuffer cmd)
		{
			// // Void DownSampleMipmapChainPhase1(CommandBuffer)
			// void HG::Rendering::Runtime::HGHierarchicalZOcclusionCulling::DownSampleMipmapChainPhase1(
			//         HGHierarchicalZOcclusionCulling *this,
			//         CommandBuffer *cmd,
			//         MethodInfo *method)
			// {
			//   ComputeShader *m_hizDownSampleCS; // rbx
			//   int32_t m_hizDownSampleKernel1; // edi
			//   int32_t HGHiZInput; // esi
			//   RTHandle *currentDepthMipChain; // rax
			//   RenderTargetIdentifier *v9; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   __int128 v12; // xmm1
			//   __int64 v13; // xmm0_8
			//   ComputeShader *v14; // rsi
			//   int32_t v15; // edi
			//   int32_t HGHiZOutput0; // ebx
			//   RTHandle *v17; // rax
			//   RenderTargetIdentifier *v18; // rax
			//   __int128 v19; // xmm1
			//   __int64 v20; // xmm0_8
			//   ComputeShader *v21; // rsi
			//   int32_t v22; // edi
			//   int32_t HGHiZOutput1; // ebx
			//   RTHandle *v24; // rax
			//   RenderTargetIdentifier *v25; // rax
			//   __int128 v26; // xmm1
			//   __int64 v27; // xmm0_8
			//   ComputeShader *v28; // rsi
			//   int32_t v29; // edi
			//   int32_t HGHiZOutput2; // ebx
			//   RTHandle *v31; // rax
			//   RenderTargetIdentifier *v32; // rax
			//   __int128 v33; // xmm1
			//   __int64 v34; // xmm0_8
			//   ComputeShader *v35; // rsi
			//   int32_t v36; // edi
			//   int32_t HGHiZOutput3; // ebx
			//   RTHandle *v38; // rax
			//   RenderTargetIdentifier *v39; // rax
			//   __int128 v40; // xmm1
			//   __int64 v41; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v43; // rdx
			//   __int64 v44; // rcx
			//   RenderTargetIdentifier v45; // [rsp+48h] [rbp-49h] BYREF
			//   RenderTargetIdentifier v46; // [rsp+78h] [rbp-19h] BYREF
			//   RenderTargetIdentifier v47; // [rsp+A8h] [rbp+17h] BYREF
			// 
			//   if ( !byte_18D919CD6 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     byte_18D919CD6 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(415, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(415, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v44, v43);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)cmd,
			//       0LL);
			//   }
			//   else if ( this.fields.m_frameCounter )
			//   {
			//     m_hizDownSampleCS = this.fields.m_hizDownSampleCS;
			//     m_hizDownSampleKernel1 = this.fields.m_hizDownSampleKernel1;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     HGHiZInput = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGHiZInput;
			//     currentDepthMipChain = HG::Rendering::Runtime::HGHierarchicalZOcclusionCulling::get_currentDepthMipChain(this, 0LL);
			//     v9 = UnityEngine::Rendering::RTHandle::op_Implicit(&v46, currentDepthMipChain, 0LL);
			//     if ( !cmd )
			//       sub_180B536AC(v11, v10);
			//     v12 = *(_OWORD *)&v9.m_BufferPointer;
			//     *(_OWORD *)&v45.m_Type = *(_OWORD *)&v9.m_Type;
			//     v13 = *(_QWORD *)&v9.m_DepthSlice;
			//     *(_OWORD *)&v45.m_BufferPointer = v12;
			//     *(_QWORD *)&v45.m_DepthSlice = v13;
			//     UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
			//       cmd,
			//       m_hizDownSampleCS,
			//       m_hizDownSampleKernel1,
			//       HGHiZInput,
			//       &v45,
			//       3,
			//       0LL);
			//     v14 = this.fields.m_hizDownSampleCS;
			//     v15 = this.fields.m_hizDownSampleKernel1;
			//     HGHiZOutput0 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGHiZOutput0;
			//     v17 = HG::Rendering::Runtime::HGHierarchicalZOcclusionCulling::get_currentDepthMipChain(this, 0LL);
			//     v18 = UnityEngine::Rendering::RTHandle::op_Implicit(&v47, v17, 0LL);
			//     v19 = *(_OWORD *)&v18.m_BufferPointer;
			//     *(_OWORD *)&v46.m_Type = *(_OWORD *)&v18.m_Type;
			//     v20 = *(_QWORD *)&v18.m_DepthSlice;
			//     *(_OWORD *)&v46.m_BufferPointer = v19;
			//     *(_QWORD *)&v46.m_DepthSlice = v20;
			//     UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(cmd, v14, v15, HGHiZOutput0, &v46, 4, 0LL);
			//     v21 = this.fields.m_hizDownSampleCS;
			//     v22 = this.fields.m_hizDownSampleKernel1;
			//     HGHiZOutput1 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGHiZOutput1;
			//     v24 = HG::Rendering::Runtime::HGHierarchicalZOcclusionCulling::get_currentDepthMipChain(this, 0LL);
			//     v25 = UnityEngine::Rendering::RTHandle::op_Implicit(&v47, v24, 0LL);
			//     v26 = *(_OWORD *)&v25.m_BufferPointer;
			//     *(_OWORD *)&v45.m_Type = *(_OWORD *)&v25.m_Type;
			//     v27 = *(_QWORD *)&v25.m_DepthSlice;
			//     *(_OWORD *)&v45.m_BufferPointer = v26;
			//     *(_QWORD *)&v45.m_DepthSlice = v27;
			//     UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(cmd, v21, v22, HGHiZOutput1, &v45, 5, 0LL);
			//     v28 = this.fields.m_hizDownSampleCS;
			//     v29 = this.fields.m_hizDownSampleKernel1;
			//     HGHiZOutput2 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGHiZOutput2;
			//     v31 = HG::Rendering::Runtime::HGHierarchicalZOcclusionCulling::get_currentDepthMipChain(this, 0LL);
			//     v32 = UnityEngine::Rendering::RTHandle::op_Implicit(&v47, v31, 0LL);
			//     v33 = *(_OWORD *)&v32.m_BufferPointer;
			//     *(_OWORD *)&v46.m_Type = *(_OWORD *)&v32.m_Type;
			//     v34 = *(_QWORD *)&v32.m_DepthSlice;
			//     *(_OWORD *)&v46.m_BufferPointer = v33;
			//     *(_QWORD *)&v46.m_DepthSlice = v34;
			//     UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(cmd, v28, v29, HGHiZOutput2, &v46, 6, 0LL);
			//     v35 = this.fields.m_hizDownSampleCS;
			//     v36 = this.fields.m_hizDownSampleKernel1;
			//     HGHiZOutput3 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGHiZOutput3;
			//     v38 = HG::Rendering::Runtime::HGHierarchicalZOcclusionCulling::get_currentDepthMipChain(this, 0LL);
			//     v39 = UnityEngine::Rendering::RTHandle::op_Implicit(&v47, v38, 0LL);
			//     v40 = *(_OWORD *)&v39.m_BufferPointer;
			//     *(_OWORD *)&v45.m_Type = *(_OWORD *)&v39.m_Type;
			//     v41 = *(_QWORD *)&v39.m_DepthSlice;
			//     *(_OWORD *)&v45.m_BufferPointer = v40;
			//     *(_QWORD *)&v45.m_DepthSlice = v41;
			//     UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(cmd, v35, v36, HGHiZOutput3, &v45, 7, 0LL);
			//     UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
			//       cmd,
			//       this.fields.m_hizDownSampleCS,
			//       this.fields.m_hizDownSampleKernel1,
			//       1,
			//       1,
			//       1,
			//       0LL);
			//   }
			// }
			// 
		}

		public void AddQuery()
		{
			// // Void AddQuery()
			// void HG::Rendering::Runtime::HGHierarchicalZOcclusionCulling::AddQuery(
			//         HGHierarchicalZOcclusionCulling *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1103, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1103, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			// }
			// 
		}

		public void Dispose()
		{
			// // Void Dispose()
			// void HG::Rendering::Runtime::HGHierarchicalZOcclusionCulling::Dispose(
			//         HGHierarchicalZOcclusionCulling *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   RTHandle *v4; // rcx
			//   RTHandle__Array *m_hizDepthMipChains; // rdi
			//   int32_t v6; // ebx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(417, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(417, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//       return;
			//     }
			// LABEL_9:
			//     sub_180B536AC(v4, v3);
			//   }
			//   m_hizDepthMipChains = this.fields.m_hizDepthMipChains;
			//   v6 = 0;
			//   if ( !m_hizDepthMipChains )
			//     goto LABEL_9;
			//   while ( v6 < m_hizDepthMipChains.max_length.size )
			//   {
			//     if ( (unsigned int)v6 >= m_hizDepthMipChains.max_length.size )
			//       sub_180070270(v4, v3);
			//     v4 = m_hizDepthMipChains.vector[v6];
			//     if ( !v4 )
			//       goto LABEL_9;
			//     UnityEngine::Rendering::RTHandle::Release(v4, 0LL);
			//     ++v6;
			//   }
			// }
			// 
		}

		public const int DEPTH_BUFFER_RESOLUTION_X = 256;

		public const int DEPTH_BUFFER_RESOLUTION_Y = 128;

		private const int COMPUTE_SHADER_LOCAL_SIZE_X = 16;

		private const int COMPUTE_SHADER_LOCAL_SIZE_Y = 8;

		private const int DEPTH_BUFFER_MIP_COUNT = 8;

		private const int DEPTH_BUFFER_COUNT = 3;

		private const int COMPUTE_SHADER_WORK_GROUP_X = 16;

		private const int COMPUTE_SHADER_WORK_GROUP_Y = 16;

		private readonly RTHandle[] m_hizDepthMipChains;

		private ushort m_frameCounter;

		private readonly ComputeShader m_hizDownSampleCS;

		private readonly int m_hizDownSampleKernel0;

		private readonly int m_hizDownSampleKernel1;
	}
}
