using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class HGConstantBufferPool
	{
		internal HGConstantBufferPool()
		{
			// // HGConstantBufferPool()
			// void HG::Rendering::Runtime::HGConstantBufferPool::HGConstantBufferPool(HGConstantBufferPool *this, MethodInfo *method)
			// {
			//   DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   DynamicArray_1_HG_Rendering_Runtime_HGConstantBufferPool_Segment_ *v6; // rdi
			//   OneofDescriptorProto *v7; // rdx
			//   FileDescriptor *v8; // r8
			//   MessageDescriptor *v9; // r9
			//   ComputeBuffer *v10; // rax
			//   ComputeBuffer *v11; // rdi
			//   OneofDescriptorProto *v12; // rdx
			//   FileDescriptor *v13; // r8
			//   MessageDescriptor *v14; // r9
			//   String__Array *usage; // [rsp+20h] [rbp-18h]
			//   String *v16; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v17; // [rsp+30h] [rbp-8h]
			//   String__Array *v18; // [rsp+60h] [rbp+28h]
			//   String *v19; // [rsp+68h] [rbp+30h]
			//   MethodInfo *v20; // [rsp+70h] [rbp+38h]
			// 
			//   if ( !byte_18D919462 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::ComputeBuffer);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::HGConstantBufferPool::Segment>::DynamicArray);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::HGConstantBufferPool::Segment>);
			//     byte_18D919462 = 1;
			//   }
			//   v3 = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)sub_180004920(TypeInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::HGConstantBufferPool::Segment>);
			//   v6 = (DynamicArray_1_HG_Rendering_Runtime_HGConstantBufferPool_Segment_ *)v3;
			//   if ( !v3
			//     || (UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::DynamicArray(
			//           v3,
			//           MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::HGConstantBufferPool::Segment>::DynamicArray),
			//         this.fields.m_allocatedSegments = v6,
			//         sub_1800054D0((OneofDescriptor *)&this.fields.m_allocatedSegments, v7, v8, v9, usage, v16, v17),
			//         v10 = (ComputeBuffer *)sub_180004920(TypeInfo::UnityEngine::ComputeBuffer),
			//         (v11 = v10) == 0LL) )
			//   {
			//     sub_180B536AC(v5, v4);
			//   }
			//   UnityEngine::ComputeBuffer::ComputeBuffer(
			//     v10,
			//     0x80000,
			//     1,
			//     ComputeBufferType__Enum_Constant,
			//     ComputeBufferMode__Enum_Dynamic,
			//     0LL);
			//   this.fields.m_GPUBuffer = v11;
			//   sub_1800054D0((OneofDescriptor *)&this.fields, v12, v13, v14, v18, v19, v20);
			// }
			// 
		}

		internal void Reset()
		{
			// // Void Reset()
			// void HG::Rendering::Runtime::HGConstantBufferPool::Reset(HGConstantBufferPool *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   DynamicArray_1_HG_Rendering_Runtime_HGConstantBufferPool_Segment_ *m_allocatedSegments; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919463 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::HGConstantBufferPool::Segment>::Resize);
			//     byte_18D919463 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2250, 0LL) )
			//   {
			//     m_allocatedSegments = this.fields.m_allocatedSegments;
			//     if ( m_allocatedSegments )
			//     {
			//       UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Resize(
			//         (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)m_allocatedSegments,
			//         0,
			//         0,
			//         MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::HGConstantBufferPool::Segment>::Resize);
			//       this.fields.m_startOffset = 0;
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(m_allocatedSegments, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2250, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		internal void ApplyPendingUpload()
		{
			// // Void ApplyPendingUpload()
			// void HG::Rendering::Runtime::HGConstantBufferPool::ApplyPendingUpload(HGConstantBufferPool *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   ComputeBuffer *m_GPUBuffer; // rcx
			//   int32_t m_startOffset; // esi
			//   int32_t stride; // eax
			//   int v7; // ebp
			//   int32_t v8; // eax
			//   ComputeBuffer *v9; // rax
			//   ComputeBuffer *v10; // rdi
			//   OneofDescriptorProto *v11; // rdx
			//   FileDescriptor *v12; // r8
			//   MessageDescriptor *v13; // r9
			//   int32_t v14; // esi
			//   ComputeBuffer *v15; // rax
			//   ComputeBuffer *v16; // rdi
			//   OneofDescriptorProto *v17; // rdx
			//   FileDescriptor *v18; // r8
			//   MessageDescriptor *v19; // r9
			//   int32_t i; // edi
			//   DynamicArray_1_HG_Rendering_Runtime_HGConstantBufferPool_Segment_ *m_allocatedSegments; // rax
			//   RenderGraph_CompiledResourceInfo *Item; // rax
			//   int32_t producers; // r9d
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   String__Array *usage; // [rsp+20h] [rbp-28h]
			//   String__Array *usagea; // [rsp+20h] [rbp-28h]
			//   ComputeBufferMode__Enum usageb; // [rsp+20h] [rbp-28h]
			//   String *v28; // [rsp+28h] [rbp-20h]
			//   String *v29; // [rsp+28h] [rbp-20h]
			//   NativeArray_1_System_Byte_ v30; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919464 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::ComputeBuffer::SetData<unsigned char>);
			//     sub_18003C530(&TypeInfo::UnityEngine::ComputeBuffer);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::HGConstantBufferPool::Segment>::get_Item);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::HGConstantBufferPool::Segment>::get_size);
			//     sub_18003C530(&TypeInfo::System::Math);
			//     byte_18D919464 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2251, 0LL) )
			//   {
			//     m_GPUBuffer = this.fields.m_GPUBuffer;
			//     m_startOffset = this.fields.m_startOffset;
			//     if ( m_GPUBuffer )
			//     {
			//       stride = UnityEngine::ComputeBuffer::get_stride(m_GPUBuffer, 0LL);
			//       m_GPUBuffer = this.fields.m_GPUBuffer;
			//       if ( m_GPUBuffer )
			//       {
			//         v7 = stride * UnityEngine::ComputeBuffer::get_count(m_GPUBuffer, 0LL);
			//         sub_180002C70(TypeInfo::System::Math);
			//         v3 = 0x80000LL;
			//         m_GPUBuffer = (ComputeBuffer *)(unsigned int)(v7 - m_startOffset);
			//         if ( (int)m_GPUBuffer >= 0x80000 )
			//           v3 = (unsigned int)m_GPUBuffer;
			//         v8 = this.fields.m_shrinkTicks + 1;
			//         this.fields.m_unusedSegmentCount = v3;
			//         this.fields.m_shrinkTicks = v8;
			//         if ( v8 >= 16 )
			//         {
			//           m_GPUBuffer = this.fields.m_GPUBuffer;
			//           if ( !m_GPUBuffer )
			//             goto LABEL_22;
			//           UnityEngine::ComputeBuffer::Dispose(m_GPUBuffer, 0LL);
			//           v9 = (ComputeBuffer *)sub_180004920(TypeInfo::UnityEngine::ComputeBuffer);
			//           v10 = v9;
			//           if ( !v9 )
			//             goto LABEL_22;
			//           UnityEngine::ComputeBuffer::ComputeBuffer(
			//             v9,
			//             v7 - 0x80000,
			//             1,
			//             ComputeBufferType__Enum_Constant,
			//             ComputeBufferMode__Enum_Dynamic,
			//             0LL);
			//           this.fields.m_GPUBuffer = v10;
			//           sub_1800054D0((OneofDescriptor *)&this.fields, v11, v12, v13, usage, v28, (MethodInfo *)v30.m_Buffer);
			//           this.fields.m_shrinkTicks = 0;
			//           --this.fields.m_unusedSegmentCount;
			//         }
			//         if ( v7 < m_startOffset )
			//         {
			//           m_GPUBuffer = this.fields.m_GPUBuffer;
			//           if ( !m_GPUBuffer )
			//             goto LABEL_22;
			//           UnityEngine::ComputeBuffer::Dispose(m_GPUBuffer, 0LL);
			//           v14 = (unsigned int)sub_1826E82D0() << 19;
			//           v15 = (ComputeBuffer *)sub_180004920(TypeInfo::UnityEngine::ComputeBuffer);
			//           v16 = v15;
			//           if ( !v15 )
			//             goto LABEL_22;
			//           UnityEngine::ComputeBuffer::ComputeBuffer(
			//             v15,
			//             v14,
			//             1,
			//             ComputeBufferType__Enum_Constant,
			//             ComputeBufferMode__Enum_Dynamic,
			//             0LL);
			//           this.fields.m_GPUBuffer = v16;
			//           sub_1800054D0((OneofDescriptor *)&this.fields, v17, v18, v19, usagea, v29, (MethodInfo *)v30.m_Buffer);
			//         }
			//         for ( i = 0; ; ++i )
			//         {
			//           m_allocatedSegments = this.fields.m_allocatedSegments;
			//           if ( !m_allocatedSegments )
			//             break;
			//           if ( i >= m_allocatedSegments.fields._size_k__BackingField )
			//             return;
			//           Item = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
			//                    (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)this.fields.m_allocatedSegments,
			//                    i,
			//                    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::HGConstantBufferPool::Segment>::get_Item);
			//           m_GPUBuffer = this.fields.m_GPUBuffer;
			//           if ( !m_GPUBuffer )
			//             break;
			//           producers = (int32_t)Item.producers;
			//           usageb = HIDWORD(Item.producers);
			//           v30 = *(NativeArray_1_System_Byte_ *)&Item.consumers;
			//           UnityEngine::ComputeBuffer::SetData<unsigned char>(
			//             m_GPUBuffer,
			//             &v30,
			//             0,
			//             producers,
			//             usageb,
			//             MethodInfo::UnityEngine::ComputeBuffer::SetData<unsigned char>);
			//         }
			//       }
			//     }
			// LABEL_22:
			//     sub_180B536AC(m_GPUBuffer, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2251, 0LL);
			//   if ( !Patch )
			//     goto LABEL_22;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		internal HGConstantBufferPool.CBHandle<CBType> Alloc<CBType>() where CBType : struct
		{
			return default(HGConstantBufferPool.CBHandle<CBType>);
		}

		private const int INC_SEGMENT_SIZE = 524288;

		private const int SHRINK_FRAME_COUNT = 16;

		private ComputeBuffer m_GPUBuffer;

		private DynamicArray<HGConstantBufferPool.Segment> m_allocatedSegments;

		private int m_startOffset;

		private int m_unusedSegmentCount;

		private int m_shrinkTicks;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct CBHandle<CBType> where CBType : struct
		{
			internal int offset;

			internal int size;

			internal unsafe CBType* ptr;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 24)]
		private struct Segment
		{
			internal int offset;

			internal int size;

			internal NativeArray<byte> data;
		}
	}
}
