using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class HGConstantBufferPool // TypeDefIndex: 38072
	{
		// Fields
		private const int INC_SEGMENT_SIZE = 524288; // Metadata: 0x02303877
		private const int SHRINK_FRAME_COUNT = 16; // Metadata: 0x0230387B
		private ComputeBuffer m_GPUBuffer; // 0x10
		private DynamicArray<Segment> m_allocatedSegments; // 0x18
		private int m_startOffset; // 0x20
		private int m_unusedSegmentCount; // 0x24
		private int m_shrinkTicks; // 0x28
	
		// Nested types
		internal struct CBHandle<CBType> // TypeDefIndex: 38070
			where CBType : struct
		{
			// Fields
			internal int offset;
			internal int size;
			internal unsafe CBType* ptr;
		}
	
		private struct Segment // TypeDefIndex: 38071
		{
			// Fields
			internal int offset; // 0x00
			internal int size; // 0x04
			internal NativeArray<byte> data; // 0x08
		}
	
		// Constructors
		internal HGConstantBufferPool() {} // 0x0000000189B6AA28-0x0000000189B6AAB8
		// HGConstantBufferPool()
		void HG::Rendering::Runtime::HGConstantBufferPool::HGConstantBufferPool(HGConstantBufferPool *this, MethodInfo *method)
		{
		  DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  DynamicArray_1_HG_Rendering_Runtime_HGConstantBufferPool_Segment_ *v6; // rdi
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  ComputeBuffer *v10; // rax
		  ComputeBuffer *v11; // rdi
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  MethodInfo *usage; // [rsp+20h] [rbp-18h]
		  MethodInfo *v16; // [rsp+60h] [rbp+28h]
		
		  v3 = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)sub_18002C620(TypeInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::HGConstantBufferPool::Segment>);
		  v6 = (DynamicArray_1_HG_Rendering_Runtime_HGConstantBufferPool_Segment_ *)v3;
		  if ( !v3
		    || (UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::DynamicArray(
		          v3,
		          MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::HGConstantBufferPool::Segment>::DynamicArray),
		        this->fields.m_allocatedSegments = v6,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_allocatedSegments, v7, v8, v9, usage),
		        v10 = (ComputeBuffer *)sub_18002C620(TypeInfo::UnityEngine::ComputeBuffer),
		        (v11 = v10) == 0LL) )
		  {
		    sub_1800D8260(v5, v4);
		  }
		  UnityEngine::ComputeBuffer::ComputeBuffer(
		    v10,
		    0x80000,
		    1,
		    ComputeBufferType__Enum_Constant,
		    ComputeBufferMode__Enum_Dynamic,
		    0LL);
		  this->fields.m_GPUBuffer = v11;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v12, v13, v14, v16);
		}
		
	
		// Methods
		internal void Reset() {} // 0x0000000189B6A9C0-0x0000000189B6AA28
		// Void Reset()
		void HG::Rendering::Runtime::HGConstantBufferPool::Reset(HGConstantBufferPool *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  DynamicArray_1_HG_Rendering_Runtime_HGConstantBufferPool_Segment_ *m_allocatedSegments; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2711, 0LL) )
		  {
		    m_allocatedSegments = this->fields.m_allocatedSegments;
		    if ( m_allocatedSegments )
		    {
		      UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Resize(
		        (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)m_allocatedSegments,
		        0,
		        0,
		        MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::HGConstantBufferPool::Segment>::Resize);
		      this->fields.m_startOffset = 0;
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(m_allocatedSegments, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2711, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		internal void ApplyPendingUpload() {} // 0x0000000189B6A7C0-0x0000000189B6A9C0
		// Void ApplyPendingUpload()
		void HG::Rendering::Runtime::HGConstantBufferPool::ApplyPendingUpload(HGConstantBufferPool *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  ComputeBuffer *m_GPUBuffer; // rcx
		  int32_t m_startOffset; // esi
		  int32_t stride; // eax
		  int v7; // ebp
		  int32_t v8; // eax
		  ComputeBuffer *v9; // rax
		  ComputeBuffer *v10; // rdi
		  Type *v11; // rdx
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  int32_t v14; // esi
		  ComputeBuffer *v15; // rax
		  ComputeBuffer *v16; // rdi
		  Type *v17; // rdx
		  PropertyInfo_1 *v18; // r8
		  Int32__Array **v19; // r9
		  int32_t i; // edi
		  DynamicArray_1_HG_Rendering_Runtime_HGConstantBufferPool_Segment_ *m_allocatedSegments; // rax
		  RenderGraph_CompiledResourceInfo *Item; // rax
		  int32_t producers; // r9d
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *usage; // [rsp+20h] [rbp-28h]
		  MethodInfo *usagea; // [rsp+20h] [rbp-28h]
		  ComputeBufferMode__Enum usageb; // [rsp+20h] [rbp-28h]
		  NativeArray_1_System_Byte_ v28; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2712, 0LL) )
		  {
		    m_GPUBuffer = this->fields.m_GPUBuffer;
		    m_startOffset = this->fields.m_startOffset;
		    if ( m_GPUBuffer )
		    {
		      stride = UnityEngine::ComputeBuffer::get_stride(m_GPUBuffer, 0LL);
		      m_GPUBuffer = this->fields.m_GPUBuffer;
		      if ( m_GPUBuffer )
		      {
		        v7 = stride * UnityEngine::ComputeBuffer::get_count(m_GPUBuffer, 0LL);
		        sub_1800036A0(TypeInfo::System::Math);
		        v3 = 0x80000LL;
		        m_GPUBuffer = (ComputeBuffer *)(unsigned int)(v7 - m_startOffset);
		        if ( (int)m_GPUBuffer >= 0x80000 )
		          v3 = (unsigned int)m_GPUBuffer;
		        v8 = this->fields.m_shrinkTicks + 1;
		        this->fields.m_unusedSegmentCount = v3;
		        this->fields.m_shrinkTicks = v8;
		        if ( v8 >= 16 )
		        {
		          m_GPUBuffer = this->fields.m_GPUBuffer;
		          if ( !m_GPUBuffer )
		            goto LABEL_20;
		          UnityEngine::ComputeBuffer::Dispose(m_GPUBuffer, 0LL);
		          v9 = (ComputeBuffer *)sub_18002C620(TypeInfo::UnityEngine::ComputeBuffer);
		          v10 = v9;
		          if ( !v9 )
		            goto LABEL_20;
		          UnityEngine::ComputeBuffer::ComputeBuffer(
		            v9,
		            v7 - 0x80000,
		            1,
		            ComputeBufferType__Enum_Constant,
		            ComputeBufferMode__Enum_Dynamic,
		            0LL);
		          this->fields.m_GPUBuffer = v10;
		          sub_18002D1B0((SingleFieldAccessor *)&this->fields, v11, v12, v13, usage);
		          this->fields.m_shrinkTicks = 0;
		          --this->fields.m_unusedSegmentCount;
		        }
		        if ( v7 < m_startOffset )
		        {
		          m_GPUBuffer = this->fields.m_GPUBuffer;
		          if ( !m_GPUBuffer )
		            goto LABEL_20;
		          UnityEngine::ComputeBuffer::Dispose(m_GPUBuffer, 0LL);
		          v14 = (unsigned int)sub_1832DBD50() << 19;
		          v15 = (ComputeBuffer *)sub_18002C620(TypeInfo::UnityEngine::ComputeBuffer);
		          v16 = v15;
		          if ( !v15 )
		            goto LABEL_20;
		          UnityEngine::ComputeBuffer::ComputeBuffer(
		            v15,
		            v14,
		            1,
		            ComputeBufferType__Enum_Constant,
		            ComputeBufferMode__Enum_Dynamic,
		            0LL);
		          this->fields.m_GPUBuffer = v16;
		          sub_18002D1B0((SingleFieldAccessor *)&this->fields, v17, v18, v19, usagea);
		        }
		        for ( i = 0; ; ++i )
		        {
		          m_allocatedSegments = this->fields.m_allocatedSegments;
		          if ( !m_allocatedSegments )
		            break;
		          if ( i >= m_allocatedSegments->fields._size_k__BackingField )
		            return;
		          Item = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
		                   (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)this->fields.m_allocatedSegments,
		                   i,
		                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::HGConstantBufferPool::Segment>::get_Item);
		          m_GPUBuffer = this->fields.m_GPUBuffer;
		          if ( !m_GPUBuffer )
		            break;
		          producers = (int32_t)Item->producers;
		          usageb = HIDWORD(Item->producers);
		          v28 = *(NativeArray_1_System_Byte_ *)&Item->consumers;
		          UnityEngine::ComputeBuffer::SetData<unsigned char>(
		            m_GPUBuffer,
		            &v28,
		            0,
		            producers,
		            usageb,
		            MethodInfo::UnityEngine::ComputeBuffer::SetData<unsigned char>);
		        }
		      }
		    }
		LABEL_20:
		    sub_1800D8260(m_GPUBuffer, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2712, 0LL);
		  if ( !Patch )
		    goto LABEL_20;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		internal CBHandle<CBType> Alloc<CBType>()
			where CBType : struct => default;
	}
}
