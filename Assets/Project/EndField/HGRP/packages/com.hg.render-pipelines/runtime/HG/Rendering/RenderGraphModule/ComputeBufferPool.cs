using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.RenderGraphModule
{
	internal class ComputeBufferPool : HGRenderGraphResourcePool<ComputeBuffer> // TypeDefIndex: 37453
	{
		// Constructors
		public ComputeBufferPool() {} // 0x00000001853945BC-0x00000001853945C8
		// ComputeBufferPool()
		void HG::Rendering::RenderGraphModule::ComputeBufferPool::ComputeBufferPool(
		        ComputeBufferPool *this,
		        MethodInfo *method)
		{
		  HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<System::Object>::HGRenderGraphResourcePool(
		    (HGRenderGraphResourcePool_1_System_Object_ *)this,
		    MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::ComputeBuffer>::HGRenderGraphResourcePool);
		}
		
	
		// Methods
		protected override void ReleaseInternalResource(ComputeBuffer res) {} // 0x0000000189B34FC0-0x0000000189B35024
		// Void ReleaseInternalResource(ComputeBuffer)
		void HG::Rendering::RenderGraphModule::ComputeBufferPool::ReleaseInternalResource(
		        ComputeBufferPool *this,
		        ComputeBuffer *res,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(300, 0LL) )
		  {
		    if ( res )
		    {
		      UnityEngine::ComputeBuffer::Dispose(res, 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(300, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)res,
		    0LL);
		}
		
		protected override string GetResourceName(ComputeBuffer res) => default; // 0x0000000189B34E34-0x0000000189B34E90
		// String GetResourceName(ComputeBuffer)
		String *HG::Rendering::RenderGraphModule::ComputeBufferPool::GetResourceName(
		        ComputeBufferPool *this,
		        ComputeBuffer *res,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(301, 0LL) )
		    return (String *)"ComputeBufferNameNotAvailable";
		  Patch = IFix::WrappersManagerImpl::GetPatch(301, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v8, v7);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_130(Patch, (Object *)this, (Object *)res, 0LL);
		}
		
		protected override long GetResourceSize(ComputeBuffer res) => default; // 0x0000000189B34E90-0x0000000189B34F08
		// Int64 GetResourceSize(ComputeBuffer)
		int64_t HG::Rendering::RenderGraphModule::ComputeBufferPool::GetResourceSize(
		        ComputeBufferPool *this,
		        ComputeBuffer *res,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  int32_t count; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(302, 0LL) )
		  {
		    if ( res )
		    {
		      count = UnityEngine::ComputeBuffer::get_count(res, 0LL);
		      return count * UnityEngine::ComputeBuffer::get_stride(res, 0LL);
		    }
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(302, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_141(Patch, (Object *)this, (Object *)res, 0LL);
		}
		
		protected override string GetResourceTypeName() => default; // 0x0000000189B34F08-0x0000000189B34F58
		// String GetResourceTypeName()
		String *HG::Rendering::RenderGraphModule::ComputeBufferPool::GetResourceTypeName(
		        ComputeBufferPool *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(303, 0LL) )
		    return (String *)"ComputeBuffer";
		  Patch = IFix::WrappersManagerImpl::GetPatch(303, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		
		protected override int GetSortIndex(ComputeBuffer res) => default; // 0x0000000189B34F58-0x0000000189B34FC0
		// Int32 GetSortIndex(ComputeBuffer)
		int32_t HG::Rendering::RenderGraphModule::ComputeBufferPool::GetSortIndex(
		        ComputeBufferPool *this,
		        ComputeBuffer *res,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(304, 0LL) )
		  {
		    if ( res )
		      return sub_180002F70(2LL, res);
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(304, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_114(
		           (ILFixDynamicMethodWrapper_17 *)Patch,
		           (Object *)this,
		           (Object *)res,
		           0LL);
		}
		
		public override void PurgeUnusedResources(int currentFrameIndex) {} // 0x0000000183BF4E00-0x0000000183BF51C0
		// Void PurgeUnusedResources(Int32)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::RenderGraphModule::ComputeBufferPool::PurgeUnusedResources(
		        ComputeBufferPool *this,
		        int32_t currentFrameIndex,
		        MethodInfo *method)
		{
		  Int32__Array **v3; // r9
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v8; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  HGRenderGraphResourcePool_1_UnityEngine_ComputeBuffer___StaticFields *static_fields; // rcx
		  List_1_System_Int32_ *m_RemoveList; // rbx
		  Dictionary_2_System_Int32_SortedList_2_System_Int32_System_ValueTuple_2_UnityEngine_ComputeBuffer_Int32_ *m_ResourcePool; // rbx
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  SortedList_2_System_Int32_System_ValueTuple_2_Object_Int32_ *value; // rsi
		  IList_1_System_Object_ *Keys; // r15
		  Type *v19; // rdx
		  HGRenderGraphResourcePool_1_UnityEngine_ComputeBuffer___StaticFields *v20; // rcx
		  PropertyInfo_1 *v21; // r8
		  IList_1_System_ValueTuple_2_Object_Int32_ *Values; // r14
		  int32_t i; // ebx
		  __m128i *v24; // rax
		  __m128i v25; // xmm1
		  __int64 v26; // rdx
		  __int64 v27; // rcx
		  List_1_System_Int32_ *v28; // rdi
		  unsigned int v29; // eax
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  List_1_System_Int32_ *v32; // r9
		  __int64 v33; // r9
		  MethodInfo *v34; // [rsp+20h] [rbp-E8h]
		  MethodInfo *v35; // [rsp+20h] [rbp-E8h]
		  List_1_T_Enumerator_System_Int32_ v36; // [rsp+30h] [rbp-D8h] BYREF
		  __int128 v37; // [rsp+48h] [rbp-C0h]
		  List_1_T_Enumerator_System_Int32_ v38; // [rsp+58h] [rbp-B0h] BYREF
		  __int64 v39; // [rsp+70h] [rbp-98h]
		  List_1_T_Enumerator_System_Int32_ *v40; // [rsp+78h] [rbp-90h]
		  __int64 v41; // [rsp+80h] [rbp-88h]
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ *v42; // [rsp+88h] [rbp-80h]
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v43; // [rsp+90h] [rbp-78h] BYREF
		  char v44; // [rsp+C8h] [rbp-40h] BYREF
		
		  memset(&v38, 0, sizeof(v38));
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v6, *(_QWORD *)&currentFrameIndex);
		  if ( wrapperArray->max_length.size <= 305 )
		    goto LABEL_12;
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v8 = v6->static_fields->wrapperArray;
		  if ( !v8 )
		    sub_1800D8260(v6, *(_QWORD *)&currentFrameIndex);
		  if ( v8->max_length.size <= 0x131u )
		    sub_1800D2AB0(v6, *(_QWORD *)&currentFrameIndex);
		  if ( v8[8].vector[17] )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(305, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
		      (ILFixDynamicMethodWrapper_29 *)Patch,
		      (Object *)this,
		      currentFrameIndex,
		      0LL);
		  }
		  else
		  {
		LABEL_12:
		    static_fields = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::ComputeBuffer>->static_fields;
		    static_fields->s_CurrentFrameIndex = currentFrameIndex;
		    m_RemoveList = this->fields._.m_RemoveList;
		    if ( !m_RemoveList )
		      sub_1800D8260(static_fields, *(_QWORD *)&currentFrameIndex);
		    ++m_RemoveList->fields._version;
		    m_RemoveList->fields._size = 0;
		    m_ResourcePool = this->fields._.m_ResourcePool;
		    if ( !m_ResourcePool )
		      sub_1800D8260(static_fields, *(_QWORD *)&currentFrameIndex);
		    *(_OWORD *)&v36._index = 0LL;
		    v37 = 0LL;
		    v36._list = (List_1_System_Int32_ *)m_ResourcePool;
		    sub_18002D1B0((SingleFieldAccessor *)&v36, *(Type **)&currentFrameIndex, (PropertyInfo_1 *)method, v3, v34);
		    *(_QWORD *)&v36._index = (unsigned int)m_ResourcePool->fields._version;
		    DWORD2(v37) = 2;
		    *(_OWORD *)&v43._dictionary = *(_OWORD *)&v36._list;
		    v43._current = 0LL;
		    *(_QWORD *)&v43._getEnumeratorRetType = *((_QWORD *)&v37 + 1);
		    v41 = 0LL;
		    v42 = &v43;
		    while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
		              &v43,
		              MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::ComputeBuffer,int>>>::MoveNext) )
		    {
		      value = (SortedList_2_System_Int32_System_ValueTuple_2_Object_Int32_ *)v43._current.value;
		      if ( !v43._current.value )
		        sub_1800D8250(v16, v15);
		      Keys = System::Collections::Generic::SortedList<System::Object,System::Object>::get_Keys(
		               (SortedList_2_System_Object_System_Object_ *)v43._current.value,
		               MethodInfo::System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::ComputeBuffer,int>>::get_Keys);
		      Values = System::Collections::Generic::SortedList<int,System::ValueTuple<System::Object,int>>::get_Values(
		                 value,
		                 MethodInfo::System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::ComputeBuffer,int>>::get_Values);
		      for ( i = 0; i < value->fields._size; ++i )
		      {
		        if ( !Values )
		          sub_1800D8250(v20, v19);
		        v24 = (__m128i *)sub_1808ADAE0((unsigned int)&v44, (_DWORD)v19, (_DWORD)v21, (_DWORD)Values, i);
		        v25 = *v24;
		        v20 = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::ComputeBuffer>->static_fields;
		        if ( _mm_cvtsi128_si32(_mm_srli_si128(*v24, 8)) + 10 < v20->s_CurrentFrameIndex )
		        {
		          if ( !v25.m128i_i64[0] )
		            sub_1800D8250(0LL, v19);
		          UnityEngine::ComputeBuffer::Dispose((ComputeBuffer *)v25.m128i_i64[0], 0LL);
		          v28 = this->fields._.m_RemoveList;
		          if ( !Keys )
		            sub_1800D8250(v27, v26);
		          v29 = sub_180003840(0LL, TypeInfo::System::Collections::Generic::IList<int>, Keys, (unsigned int)i);
		          if ( !v28 )
		            sub_1800D8250(v31, v30);
		          sub_183081250(v28, v29, MethodInfo::System::Collections::Generic::List<int>::Add);
		        }
		      }
		      v32 = this->fields._.m_RemoveList;
		      if ( !v32 )
		        sub_1800D8250(v20, v19);
		      *(_OWORD *)&v36._index = 0LL;
		      v36._list = v32;
		      sub_18002D1B0((SingleFieldAccessor *)&v36, v19, v21, (Int32__Array **)v32, v35);
		      v36._index = 0;
		      v36._version = *(_DWORD *)(v33 + 28);
		      v36._current = 0;
		      v38 = v36;
		      v39 = 0LL;
		      v40 = &v38;
		      while ( System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext(
		                &v38,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext) )
		        System::Collections::Generic::SortedList<int,System::ValueTuple<System::Object,int>>::Remove(
		          value,
		          v38._current,
		          MethodInfo::System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::ComputeBuffer,int>>::Remove);
		    }
		  }
		}
		
	}
}
