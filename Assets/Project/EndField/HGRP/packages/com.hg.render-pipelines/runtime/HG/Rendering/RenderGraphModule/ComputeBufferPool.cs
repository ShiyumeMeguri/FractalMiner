using System;
using UnityEngine;

namespace HG.Rendering.RenderGraphModule
{
	internal class ComputeBufferPool : HGRenderGraphResourcePool<ComputeBuffer>
	{
		public ComputeBufferPool()
		{
			// // ComputeBufferPool()
			// void HG::Rendering::RenderGraphModule::ComputeBufferPool::ComputeBufferPool(
			//         ComputeBufferPool *this,
			//         MethodInfo *method)
			// {
			//   if ( !byte_18D8ED951 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::ComputeBuffer>::HGRenderGraphResourcePool);
			//     byte_18D8ED951 = 1;
			//   }
			//   HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<System::Object>::HGRenderGraphResourcePool(
			//     (HGRenderGraphResourcePool_1_System_Object_ *)this,
			//     MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::ComputeBuffer>::HGRenderGraphResourcePool);
			// }
			// 
		}

		protected override void ReleaseInternalResource(ComputeBuffer res)
		{
			// // Void ReleaseInternalResource(ComputeBuffer)
			// void HG::Rendering::RenderGraphModule::ComputeBufferPool::ReleaseInternalResource(
			//         ComputeBufferPool *this,
			//         ComputeBuffer *res,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(293, 0LL) )
			//   {
			//     if ( res )
			//     {
			//       UnityEngine::ComputeBuffer::Dispose(res, 0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(293, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)res,
			//     0LL);
			// }
			// 
		}

		protected override string GetResourceName(ComputeBuffer res)
		{
			// // String GetResourceName(ComputeBuffer)
			// String *HG::Rendering::RenderGraphModule::ComputeBufferPool::GetResourceName(
			//         ComputeBufferPool *this,
			//         ComputeBuffer *res,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( !byte_18D919375 )
			//   {
			//     sub_18003C530(&off_18D4DF998);
			//     byte_18D919375 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(294, 0LL) )
			//     return (String *)"ComputeBufferNameNotAvailable";
			//   Patch = IFix::WrappersManagerImpl::GetPatch(294, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v8, v7);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_128(Patch, (Object *)this, (Object *)res, 0LL);
			// }
			// 
			return null;
		}

		protected override long GetResourceSize(ComputeBuffer res)
		{
			// // Int64 GetResourceSize(ComputeBuffer)
			// int64_t HG::Rendering::RenderGraphModule::ComputeBufferPool::GetResourceSize(
			//         ComputeBufferPool *this,
			//         ComputeBuffer *res,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   int32_t count; // ebx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(295, 0LL) )
			//   {
			//     if ( res )
			//     {
			//       count = UnityEngine::ComputeBuffer::get_count(res, 0LL);
			//       return count * UnityEngine::ComputeBuffer::get_stride(res, 0LL);
			//     }
			// LABEL_5:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(295, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return (int64_t)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_30(
			//                     (ILFixDynamicMethodWrapper_20 *)Patch,
			//                     (Object *)this,
			//                     (Object *)res,
			//                     0LL);
			// }
			// 
			return 0L;
		}

		protected override string GetResourceTypeName()
		{
			// // String GetResourceTypeName()
			// String *HG::Rendering::RenderGraphModule::ComputeBufferPool::GetResourceTypeName(
			//         ComputeBufferPool *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !byte_18D919376 )
			//   {
			//     sub_18003C530(&off_18D4DF980);
			//     byte_18D919376 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(296, 0LL) )
			//     return (String *)"ComputeBuffer";
			//   Patch = IFix::WrappersManagerImpl::GetPatch(296, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_48(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		protected override int GetSortIndex(ComputeBuffer res)
		{
			// // Int32 GetSortIndex(ComputeBuffer)
			// int32_t HG::Rendering::RenderGraphModule::ComputeBufferPool::GetSortIndex(
			//         ComputeBufferPool *this,
			//         ComputeBuffer *res,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(297, 0LL) )
			//   {
			//     if ( res )
			//       return sub_18003ED00(2LL);
			// LABEL_5:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(297, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_99(
			//            (ILFixDynamicMethodWrapper_17 *)Patch,
			//            (Object *)this,
			//            (Object *)res,
			//            0LL);
			// }
			// 
			return 0;
		}

		public override void PurgeUnusedResources(int currentFrameIndex)
		{
			// // Void PurgeUnusedResources(Int32)
			// // local variable allocation has failed, the output may be wrong!
			// void HG::Rendering::RenderGraphModule::ComputeBufferPool::PurgeUnusedResources(
			//         ComputeBufferPool *this,
			//         int32_t currentFrameIndex,
			//         MethodInfo *method)
			// {
			//   MessageDescriptor *v3; // r9
			//   struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
			//   ILFixDynamicMethodWrapper_2__Array *v8; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   HGRenderGraphResourcePool_1_UnityEngine_ComputeBuffer___StaticFields *static_fields; // rcx
			//   List_1_System_Int32_ *m_RemoveList; // rbx
			//   Dictionary_2_System_Int32_SortedList_2_System_Int32_System_ValueTuple_2_UnityEngine_ComputeBuffer_Int32_ *m_ResourcePool; // rbx
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   SortedList_2_System_Object_System_Object_ *value; // rsi
			//   IList_1_System_Object_ *Keys; // r15
			//   OneofDescriptorProto *v19; // rdx
			//   HGRenderGraphResourcePool_1_UnityEngine_ComputeBuffer___StaticFields *v20; // rcx
			//   FileDescriptor *v21; // r8
			//   IList_1_System_Object_ *Values; // r14
			//   int32_t i; // ebx
			//   __m128i *v24; // rax
			//   __m128i v25; // xmm1
			//   __int64 v26; // rdx
			//   __int64 v27; // rcx
			//   List_1_System_Int32_ *v28; // rdi
			//   int32_t v29; // eax
			//   __int64 v30; // rdx
			//   __int64 v31; // rcx
			//   List_1_System_Int32_ *v32; // r9
			//   __int64 v33; // r9
			//   String__Array *v34; // [rsp+20h] [rbp-E8h]
			//   String__Array *v35; // [rsp+20h] [rbp-E8h]
			//   String *v36; // [rsp+28h] [rbp-E0h]
			//   String *v37; // [rsp+28h] [rbp-E0h]
			//   OneofDescriptor v38; // [rsp+30h] [rbp-D8h] BYREF
			//   __int64 v39; // [rsp+80h] [rbp-88h]
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ *v40; // [rsp+88h] [rbp-80h]
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v41; // [rsp+90h] [rbp-78h] BYREF
			//   char v42; // [rsp+C8h] [rbp-40h] BYREF
			// 
			//   if ( !byte_18D8ED950 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::ComputeBuffer,int>>>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::ComputeBuffer,int>>>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::ComputeBuffer,int>>>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::ComputeBuffer,int>>>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::get_Current);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::ComputeBuffer>::ShouldReleaseResource);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::ComputeBuffer>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::IList<System::ValueTuple<UnityEngine::ComputeBuffer,int>>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::IList<int>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<int,System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::ComputeBuffer,int>>>::get_Value);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::ComputeBuffer,int>>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::ComputeBuffer,int>>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::ComputeBuffer,int>>::get_Keys);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::ComputeBuffer,int>>::get_Values);
			//     byte_18D8ED950 = 1;
			//   }
			//   memset(&v38.fields.containingType, 0, 24);
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, *(_QWORD *)&currentFrameIndex);
			//     v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v6.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     sub_180B536AC(v6, *(_QWORD *)&currentFrameIndex);
			//   if ( wrapperArray.max_length.size <= 298 )
			//     goto LABEL_16;
			//   if ( !v6._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v6, *(_QWORD *)&currentFrameIndex);
			//     v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v8 = v6.static_fields.wrapperArray;
			//   if ( !v8 )
			//     sub_180B536AC(v6, *(_QWORD *)&currentFrameIndex);
			//   if ( v8.max_length.size <= 0x12Au )
			//     sub_180070270(v6, *(_QWORD *)&currentFrameIndex);
			//   if ( v8[8].vector[10] )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(298, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
			//       (ILFixDynamicMethodWrapper_26 *)Patch,
			//       (Object *)this,
			//       currentFrameIndex,
			//       0LL);
			//   }
			//   else
			//   {
			// LABEL_16:
			//     static_fields = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::ComputeBuffer>.static_fields;
			//     static_fields.s_CurrentFrameIndex = currentFrameIndex;
			//     m_RemoveList = this.fields._.m_RemoveList;
			//     if ( !m_RemoveList )
			//       sub_180B536AC(static_fields, *(_QWORD *)&currentFrameIndex);
			//     ++m_RemoveList.fields._version;
			//     m_RemoveList.fields._size = 0;
			//     m_ResourcePool = this.fields._.m_ResourcePool;
			//     if ( !m_ResourcePool )
			//       sub_180B536AC(static_fields, *(_QWORD *)&currentFrameIndex);
			//     memset(&v38.monitor, 0, 32);
			//     v38.klass = (OneofDescriptor__Class *)m_ResourcePool;
			//     ((void (__stdcall *)(OneofDescriptor *, OneofDescriptorProto *, FileDescriptor *, MessageDescriptor *, String__Array *, String *))sub_1800054D0)(
			//       &v38,
			//       *(OneofDescriptorProto **)&currentFrameIndex,
			//       (FileDescriptor *)method,
			//       v3,
			//       v34,
			//       v36);
			//     v38.monitor = (MonitorData *)(unsigned int)m_ResourcePool.fields._version;
			//     LODWORD(v38.fields._._File_k__BackingField) = 2;
			//     *(_OWORD *)&v41._dictionary = *(_OWORD *)&v38.klass;
			//     v41._current = 0LL;
			//     *(_QWORD *)&v41._getEnumeratorRetType = v38.fields._._File_k__BackingField;
			//     v39 = 0LL;
			//     v40 = &v41;
			//     while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
			//               &v41,
			//               MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::ComputeBuffer,int>>>::MoveNext) )
			//     {
			//       value = (SortedList_2_System_Object_System_Object_ *)v41._current.value;
			//       if ( !v41._current.value )
			//         sub_1802DC2C8(v16, v15);
			//       Keys = System::Collections::Generic::SortedList<System::Object,System::Object>::get_Keys(
			//                (SortedList_2_System_Object_System_Object_ *)v41._current.value,
			//                MethodInfo::System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::ComputeBuffer,int>>::get_Keys);
			//       Values = System::Collections::Generic::SortedList<System::Object,System::Object>::get_Values(
			//                  value,
			//                  MethodInfo::System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::ComputeBuffer,int>>::get_Values);
			//       for ( i = 0; i < value.fields._size; ++i )
			//       {
			//         if ( !Values )
			//           sub_1802DC2C8(v20, v19);
			//         v24 = (__m128i *)sub_18082F230((unsigned int)&v42, (_DWORD)v19, (_DWORD)v21, (_DWORD)Values, i);
			//         v25 = *v24;
			//         v20 = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::ComputeBuffer>.static_fields;
			//         if ( _mm_cvtsi128_si32(_mm_srli_si128(*v24, 8)) + 10 < v20.s_CurrentFrameIndex )
			//         {
			//           if ( !v25.m128i_i64[0] )
			//             sub_1802DC2C8(0LL, v19);
			//           UnityEngine::ComputeBuffer::Dispose((ComputeBuffer *)v25.m128i_i64[0], 0LL);
			//           v28 = this.fields._.m_RemoveList;
			//           if ( !Keys )
			//             sub_1802DC2C8(v27, v26);
			//           v29 = sub_180002FC0(0LL, TypeInfo::System::Collections::Generic::IList<int>, Keys, (unsigned int)i);
			//           if ( !v28 )
			//             sub_1802DC2C8(v31, v30);
			//           sub_18231EF50(v28, v29);
			//         }
			//       }
			//       v32 = this.fields._.m_RemoveList;
			//       if ( !v32 )
			//         sub_1802DC2C8(v20, v19);
			//       *(_OWORD *)&v38.monitor = 0LL;
			//       v38.klass = (OneofDescriptor__Class *)v32;
			//       ((void (__stdcall *)(OneofDescriptor *, OneofDescriptorProto *, FileDescriptor *, MessageDescriptor *, String__Array *, String *))sub_1800054D0)(
			//         &v38,
			//         v19,
			//         v21,
			//         (MessageDescriptor *)v32,
			//         v35,
			//         v37);
			//       LODWORD(v38.monitor) = 0;
			//       HIDWORD(v38.monitor) = *(_DWORD *)(v33 + 28);
			//       v38.fields._._Index_k__BackingField = 0;
			//       *(_OWORD *)&v38.fields.containingType = *(_OWORD *)&v38.klass;
			//       v38.fields.accessor = *(OneofAccessor **)&v38.fields._._Index_k__BackingField;
			//       v38.fields._Proto_k__BackingField = 0LL;
			//       *(_QWORD *)&v38.fields._IsSynthetic_k__BackingField = &v38.fields.containingType;
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<unsigned int>::MoveNext(
			//                 (List_1_T_Enumerator_System_UInt32_ *)&v38.fields.containingType,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext) )
			//         System::Collections::Generic::SortedList<int,System::ValueTuple<System::Object,int>>::Remove(
			//           (SortedList_2_System_Int32_System_ValueTuple_2_Object_Int32_ *)value,
			//           (int32_t)v38.fields.accessor,
			//           MethodInfo::System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::ComputeBuffer,int>>::Remove);
			//     }
			//   }
			// }
			// 
		}
	}
}
