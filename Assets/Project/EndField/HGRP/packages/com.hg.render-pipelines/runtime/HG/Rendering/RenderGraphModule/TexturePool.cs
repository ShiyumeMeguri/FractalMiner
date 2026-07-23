using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.RenderGraphModule
{
	internal class TexturePool : HGRenderGraphResourcePool<RTHandle> // TypeDefIndex: 37473
	{
		// Constructors
		public TexturePool() {} // 0x00000001853945B0-0x00000001853945BC
		// TexturePool()
		void HG::Rendering::RenderGraphModule::TexturePool::TexturePool(TexturePool *this, MethodInfo *method)
		{
		  HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<System::Object>::HGRenderGraphResourcePool(
		    (HGRenderGraphResourcePool_1_System_Object_ *)this,
		    MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::Rendering::RTHandle>::HGRenderGraphResourcePool);
		}
		
	
		// Methods
		protected override void ReleaseInternalResource(RTHandle res) {} // 0x0000000189B41F20-0x0000000189B41F84
		// Void ReleaseInternalResource(RTHandle)
		void HG::Rendering::RenderGraphModule::TexturePool::ReleaseInternalResource(
		        TexturePool *this,
		        RTHandle *res,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(336, 0LL) )
		  {
		    if ( res )
		    {
		      UnityEngine::Rendering::RTHandle::Release(res, 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(336, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)res,
		    0LL);
		}
		
		protected override string GetResourceName(RTHandle res) => default; // 0x0000000189B41D98-0x0000000189B41E04
		// String GetResourceName(RTHandle)
		String *HG::Rendering::RenderGraphModule::TexturePool::GetResourceName(
		        TexturePool *this,
		        RTHandle *res,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  Object_1 *m_RT; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(337, 0LL) )
		  {
		    if ( res )
		    {
		      m_RT = (Object_1 *)res->fields.m_RT;
		      if ( m_RT )
		        return UnityEngine::Object::get_name(m_RT, 0LL);
		    }
		LABEL_6:
		    sub_1800D8260(m_RT, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(337, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_130(Patch, (Object *)this, (Object *)res, 0LL);
		}
		
		protected override long GetResourceSize(RTHandle res) => default; // 0x0000000189B41E04-0x0000000189B41E6C
		// Int64 GetResourceSize(RTHandle)
		int64_t HG::Rendering::RenderGraphModule::TexturePool::GetResourceSize(
		        TexturePool *this,
		        RTHandle *res,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(338, 0LL) )
		  {
		    if ( res )
		      return UnityEngine::Profiling::Profiler::GetRuntimeMemorySizeLong((Object_1 *)res->fields.m_RT, 0LL);
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(338, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_141(Patch, (Object *)this, (Object *)res, 0LL);
		}
		
		protected override string GetResourceTypeName() => default; // 0x0000000189B41E6C-0x0000000189B41EBC
		// String GetResourceTypeName()
		String *HG::Rendering::RenderGraphModule::TexturePool::GetResourceTypeName(TexturePool *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(339, 0LL) )
		    return (String *)"Texture";
		  Patch = IFix::WrappersManagerImpl::GetPatch(339, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		
		protected override int GetSortIndex(RTHandle res) => default; // 0x0000000189B41EBC-0x0000000189B41F20
		// Int32 GetSortIndex(RTHandle)
		int32_t HG::Rendering::RenderGraphModule::TexturePool::GetSortIndex(
		        TexturePool *this,
		        RTHandle *res,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(340, 0LL) )
		  {
		    if ( res )
		      return UnityEngine::Rendering::RTHandle::GetInstanceID(res, 0LL);
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(340, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_114(
		           (ILFixDynamicMethodWrapper_17 *)Patch,
		           (Object *)this,
		           (Object *)res,
		           0LL);
		}
		
		public override void PurgeUnusedResources(int currentFrameIndex) {} // 0x0000000183BF4A40-0x0000000183BF4E00
		// Void PurgeUnusedResources(Int32)
		// local variable allocation has failed, the output may be wrong!
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::RenderGraphModule::TexturePool::PurgeUnusedResources(
		        TexturePool *this,
		        int32_t currentFrameIndex,
		        MethodInfo *method)
		{
		  Int32__Array **v3; // r9
		  Object *v5; // r13
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v8; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  HGRenderGraphResourcePool_1_UnityEngine_Rendering_RTHandle___StaticFields *static_fields; // rcx
		  MonitorData *monitor; // rbx
		  Object__Class *klass; // rbx
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  SortedList_2_System_Int32_System_ValueTuple_2_Object_Int32_ *value; // rsi
		  IList_1_System_Object_ *Keys; // r15
		  Type *v19; // rdx
		  HGRenderGraphResourcePool_1_UnityEngine_Rendering_RTHandle___StaticFields *v20; // rcx
		  PropertyInfo_1 *v21; // r8
		  IList_1_System_ValueTuple_2_Object_Int32_ *Values; // r14
		  int32_t i; // ebx
		  __m128i *v24; // rax
		  __m128i v25; // xmm1
		  __int64 v26; // rdx
		  __int64 v27; // rcx
		  MonitorData *v28; // rdi
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
		  Il2CppException *ex; // [rsp+70h] [rbp-98h]
		  List_1_T_Enumerator_System_Int32_ *v40; // [rsp+78h] [rbp-90h]
		  Il2CppException *v41; // [rsp+80h] [rbp-88h]
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ *v42; // [rsp+88h] [rbp-80h]
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v43; // [rsp+90h] [rbp-78h] BYREF
		  Il2CppExceptionWrapper *v44; // [rsp+B8h] [rbp-50h] BYREF
		  Il2CppExceptionWrapper *v45; // [rsp+C0h] [rbp-48h] BYREF
		  char v46; // [rsp+C8h] [rbp-40h] BYREF
		
		  v5 = (Object *)this;
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
		  if ( wrapperArray->max_length.size <= 341 )
		    goto LABEL_13;
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v8 = v6->static_fields->wrapperArray;
		  if ( !v8 )
		    sub_1800D8260(v6, *(_QWORD *)&currentFrameIndex);
		  if ( v8->max_length.size <= 0x155u )
		    sub_1800D2AB0(v6, *(_QWORD *)&currentFrameIndex);
		  if ( v8[9].vector[17] )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(341, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)Patch, v5, currentFrameIndex, 0LL);
		  }
		  else
		  {
		LABEL_13:
		    static_fields = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::Rendering::RTHandle>->static_fields;
		    static_fields->s_CurrentFrameIndex = currentFrameIndex;
		    monitor = v5[1].monitor;
		    if ( !monitor )
		      sub_1800D8260(static_fields, *(_QWORD *)&currentFrameIndex);
		    ++*((_DWORD *)monitor + 7);
		    *((_DWORD *)monitor + 6) = 0;
		    klass = v5[1].klass;
		    if ( !klass )
		      sub_1800D8260(static_fields, *(_QWORD *)&currentFrameIndex);
		    *(_OWORD *)&v36._index = 0LL;
		    v37 = 0LL;
		    v36._list = (List_1_System_Int32_ *)klass;
		    sub_18002D1B0((SingleFieldAccessor *)&v36, *(Type **)&currentFrameIndex, (PropertyInfo_1 *)method, v3, v34);
		    *(_QWORD *)&v36._index = *((unsigned int *)&klass->_0.byval_arg + 3);
		    DWORD2(v37) = 2;
		    *(_OWORD *)&v43._dictionary = *(_OWORD *)&v36._list;
		    v43._current = 0LL;
		    *(_QWORD *)&v43._getEnumeratorRetType = *((_QWORD *)&v37 + 1);
		    v41 = 0LL;
		    v42 = &v43;
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
		                &v43,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::Rendering::RTHandle,int>>>::MoveNext) )
		      {
		        value = (SortedList_2_System_Int32_System_ValueTuple_2_Object_Int32_ *)v43._current.value;
		        if ( !v43._current.value )
		          sub_1800D8250(v16, v15);
		        Keys = System::Collections::Generic::SortedList<System::Object,System::Object>::get_Keys(
		                 (SortedList_2_System_Object_System_Object_ *)v43._current.value,
		                 MethodInfo::System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::Rendering::RTHandle,int>>::get_Keys);
		        Values = System::Collections::Generic::SortedList<int,System::ValueTuple<System::Object,int>>::get_Values(
		                   value,
		                   MethodInfo::System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::Rendering::RTHandle,int>>::get_Values);
		        for ( i = 0; i < value->fields._size; ++i )
		        {
		          if ( !Values )
		            sub_1800D8250(v20, v19);
		          v24 = (__m128i *)sub_1808ADB9C((unsigned int)&v46, (_DWORD)v19, (_DWORD)v21, (_DWORD)Values, i);
		          v25 = *v24;
		          v20 = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::Rendering::RTHandle>->static_fields;
		          if ( _mm_cvtsi128_si32(_mm_srli_si128(*v24, 8)) + 10 < v20->s_CurrentFrameIndex )
		          {
		            if ( !v25.m128i_i64[0] )
		              sub_1800D8250(0LL, v19);
		            UnityEngine::Rendering::RTHandle::Release((RTHandle *)v25.m128i_i64[0], 0LL);
		            v28 = v5[1].monitor;
		            if ( !Keys )
		              sub_1800D8250(v27, v26);
		            v29 = sub_180003840(0LL, TypeInfo::System::Collections::Generic::IList<int>, Keys, (unsigned int)i);
		            if ( !v28 )
		              sub_1800D8250(v31, v30);
		            sub_183081250(v28, v29, MethodInfo::System::Collections::Generic::List<int>::Add);
		          }
		        }
		        v32 = (List_1_System_Int32_ *)v5[1].monitor;
		        if ( !v32 )
		          sub_1800D8250(v20, v19);
		        *(_OWORD *)&v36._index = 0LL;
		        v36._list = v32;
		        sub_18002D1B0((SingleFieldAccessor *)&v36, v19, v21, (Int32__Array **)v32, v35);
		        v36._index = 0;
		        v36._version = *(_DWORD *)(v33 + 28);
		        v36._current = 0;
		        v38 = v36;
		        ex = 0LL;
		        v40 = &v38;
		        try
		        {
		          while ( System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext(
		                    &v38,
		                    MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext) )
		            System::Collections::Generic::SortedList<int,System::ValueTuple<System::Object,int>>::Remove(
		              value,
		              v38._current,
		              MethodInfo::System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::Rendering::RTHandle,int>>::Remove);
		        }
		        catch ( Il2CppExceptionWrapper *v44 )
		        {
		          ex = v44->ex;
		          if ( ex )
		            sub_18007E1E0(ex);
		          v5 = (Object *)this;
		        }
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v45 )
		    {
		      v41 = v45->ex;
		      if ( v41 )
		        sub_18007E1E0(v41);
		    }
		  }
		}
		
	}
}
