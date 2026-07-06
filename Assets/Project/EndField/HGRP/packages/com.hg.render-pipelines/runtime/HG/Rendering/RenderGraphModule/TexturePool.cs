using System;
using UnityEngine.Rendering;

namespace HG.Rendering.RenderGraphModule
{
	internal class TexturePool : HGRenderGraphResourcePool<RTHandle>
	{
		public TexturePool()
		{
			// // TexturePool()
			// void HG::Rendering::RenderGraphModule::TexturePool::TexturePool(TexturePool *this, MethodInfo *method)
			// {
			//   if ( !byte_18D8ED956 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::Rendering::RTHandle>::HGRenderGraphResourcePool);
			//     byte_18D8ED956 = 1;
			//   }
			//   HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<System::Object>::HGRenderGraphResourcePool(
			//     (HGRenderGraphResourcePool_1_System_Object_ *)this,
			//     MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::Rendering::RTHandle>::HGRenderGraphResourcePool);
			// }
			// 
		}

		protected override void ReleaseInternalResource(RTHandle res)
		{
			// // Void ReleaseInternalResource(RTHandle)
			// void HG::Rendering::RenderGraphModule::TexturePool::ReleaseInternalResource(
			//         TexturePool *this,
			//         RTHandle *res,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(329, 0LL) )
			//   {
			//     if ( res )
			//     {
			//       UnityEngine::Rendering::RTHandle::Release(res, 0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(329, 0LL);
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

		protected override string GetResourceName(RTHandle res)
		{
			// // String GetResourceName(RTHandle)
			// String *HG::Rendering::RenderGraphModule::TexturePool::GetResourceName(
			//         TexturePool *this,
			//         RTHandle *res,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   Object_1 *m_RT; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(330, 0LL) )
			//   {
			//     if ( res )
			//     {
			//       m_RT = (Object_1 *)res.fields.m_RT;
			//       if ( m_RT )
			//         return UnityEngine::Object::get_name(m_RT, 0LL);
			//     }
			// LABEL_6:
			//     sub_180B536AC(m_RT, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(330, 0LL);
			//   if ( !Patch )
			//     goto LABEL_6;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_128(Patch, (Object *)this, (Object *)res, 0LL);
			// }
			// 
			return null;
		}

		protected override long GetResourceSize(RTHandle res)
		{
			// // Int64 GetResourceSize(RTHandle)
			// int64_t HG::Rendering::RenderGraphModule::TexturePool::GetResourceSize(
			//         TexturePool *this,
			//         RTHandle *res,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(331, 0LL) )
			//   {
			//     if ( res )
			//       return UnityEngine::Profiling::Profiler::GetRuntimeMemorySizeLong((Object_1 *)res.fields.m_RT, 0LL);
			// LABEL_5:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(331, 0LL);
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
			// String *HG::Rendering::RenderGraphModule::TexturePool::GetResourceTypeName(TexturePool *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !byte_18D9193C0 )
			//   {
			//     sub_18003C530(&off_18D4DF260);
			//     byte_18D9193C0 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(332, 0LL) )
			//     return (String *)"Texture";
			//   Patch = IFix::WrappersManagerImpl::GetPatch(332, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_48(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		protected override int GetSortIndex(RTHandle res)
		{
			// // Int32 GetSortIndex(RTHandle)
			// int32_t HG::Rendering::RenderGraphModule::TexturePool::GetSortIndex(
			//         TexturePool *this,
			//         RTHandle *res,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(333, 0LL) )
			//   {
			//     if ( res )
			//       return UnityEngine::Rendering::RTHandle::GetInstanceID(res, 0LL);
			// LABEL_5:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(333, 0LL);
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
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::RenderGraphModule::TexturePool::PurgeUnusedResources(
			//         TexturePool *this,
			//         int32_t currentFrameIndex,
			//         MethodInfo *method)
			// {
			//   MessageDescriptor *v3; // r9
			//   Object *v5; // r13
			//   struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
			//   ILFixDynamicMethodWrapper_2__Array *v8; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   HGRenderGraphResourcePool_1_UnityEngine_Rendering_RTHandle___StaticFields *static_fields; // rcx
			//   MonitorData *monitor; // rbx
			//   Object__Class *klass; // rbx
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   SortedList_2_System_Object_System_Object_ *value; // rsi
			//   IList_1_System_Object_ *Keys; // r15
			//   OneofDescriptorProto *v19; // rdx
			//   HGRenderGraphResourcePool_1_UnityEngine_Rendering_RTHandle___StaticFields *v20; // rcx
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
			//   OneofDescriptor__Class *v32; // r9
			//   __int64 v33; // r9
			//   String__Array *v34; // [rsp+20h] [rbp-E8h]
			//   String__Array *v35; // [rsp+20h] [rbp-E8h]
			//   String *v36; // [rsp+28h] [rbp-E0h]
			//   String *v37; // [rsp+28h] [rbp-E0h]
			//   OneofDescriptor v38; // [rsp+30h] [rbp-D8h] BYREF
			//   Il2CppException *ex; // [rsp+80h] [rbp-88h]
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ *v40; // [rsp+88h] [rbp-80h]
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v41; // [rsp+90h] [rbp-78h] BYREF
			//   Il2CppExceptionWrapper *v42; // [rsp+B8h] [rbp-50h] BYREF
			//   Il2CppExceptionWrapper *v43; // [rsp+C0h] [rbp-48h] BYREF
			//   char v44; // [rsp+C8h] [rbp-40h] BYREF
			// 
			//   v5 = (Object *)this;
			//   if ( !byte_18D8ED955 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::Rendering::RTHandle,int>>>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::Rendering::RTHandle,int>>>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::Rendering::RTHandle,int>>>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::Rendering::RTHandle,int>>>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::get_Current);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::Rendering::RTHandle>::ShouldReleaseResource);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::Rendering::RTHandle>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::IList<System::ValueTuple<UnityEngine::Rendering::RTHandle,int>>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::IList<int>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<int,System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::Rendering::RTHandle,int>>>::get_Value);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::Rendering::RTHandle,int>>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::Rendering::RTHandle,int>>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::Rendering::RTHandle,int>>::get_Keys);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::Rendering::RTHandle,int>>::get_Values);
			//     byte_18D8ED955 = 1;
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
			//   if ( wrapperArray.max_length.size <= 334 )
			//     goto LABEL_17;
			//   if ( !v6._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v6, *(_QWORD *)&currentFrameIndex);
			//     v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v8 = v6.static_fields.wrapperArray;
			//   if ( !v8 )
			//     sub_180B536AC(v6, *(_QWORD *)&currentFrameIndex);
			//   if ( v8.max_length.size <= 0x14Eu )
			//     sub_180070270(v6, *(_QWORD *)&currentFrameIndex);
			//   if ( v8[9].vector[10] )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(334, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_26 *)Patch, v5, currentFrameIndex, 0LL);
			//   }
			//   else
			//   {
			// LABEL_17:
			//     static_fields = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::Rendering::RTHandle>.static_fields;
			//     static_fields.s_CurrentFrameIndex = currentFrameIndex;
			//     monitor = v5[1].monitor;
			//     if ( !monitor )
			//       sub_180B536AC(static_fields, *(_QWORD *)&currentFrameIndex);
			//     ++*((_DWORD *)monitor + 7);
			//     *((_DWORD *)monitor + 6) = 0;
			//     klass = v5[1].klass;
			//     if ( !klass )
			//       sub_180B536AC(static_fields, *(_QWORD *)&currentFrameIndex);
			//     memset(&v38.monitor, 0, 32);
			//     v38.klass = (OneofDescriptor__Class *)klass;
			//     ((void (__stdcall *)(OneofDescriptor *, OneofDescriptorProto *, FileDescriptor *, MessageDescriptor *, String__Array *, String *))sub_1800054D0)(
			//       &v38,
			//       *(OneofDescriptorProto **)&currentFrameIndex,
			//       (FileDescriptor *)method,
			//       v3,
			//       v34,
			//       v36);
			//     v38.monitor = (MonitorData *)*((unsigned int *)&klass._0.byval_arg + 3);
			//     LODWORD(v38.fields._._File_k__BackingField) = 2;
			//     *(_OWORD *)&v41._dictionary = *(_OWORD *)&v38.klass;
			//     v41._current = 0LL;
			//     *(_QWORD *)&v41._getEnumeratorRetType = v38.fields._._File_k__BackingField;
			//     ex = 0LL;
			//     v40 = &v41;
			//     try
			//     {
			//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
			//                 &v41,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::Rendering::RTHandle,int>>>::MoveNext) )
			//       {
			//         value = (SortedList_2_System_Object_System_Object_ *)v41._current.value;
			//         if ( !v41._current.value )
			//           sub_1802DC2C8(v16, v15);
			//         Keys = System::Collections::Generic::SortedList<System::Object,System::Object>::get_Keys(
			//                  (SortedList_2_System_Object_System_Object_ *)v41._current.value,
			//                  MethodInfo::System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::Rendering::RTHandle,int>>::get_Keys);
			//         Values = System::Collections::Generic::SortedList<System::Object,System::Object>::get_Values(
			//                    value,
			//                    MethodInfo::System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::Rendering::RTHandle,int>>::get_Values);
			//         for ( i = 0; i < value.fields._size; ++i )
			//         {
			//           if ( !Values )
			//             sub_1802DC2C8(v20, v19);
			//           v24 = (__m128i *)sub_18082F2EC((unsigned int)&v44, (_DWORD)v19, (_DWORD)v21, (_DWORD)Values, i);
			//           v25 = *v24;
			//           v20 = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::Rendering::RTHandle>.static_fields;
			//           if ( _mm_cvtsi128_si32(_mm_srli_si128(*v24, 8)) + 10 < v20.s_CurrentFrameIndex )
			//           {
			//             if ( !v25.m128i_i64[0] )
			//               sub_1802DC2C8(0LL, v19);
			//             UnityEngine::Rendering::RTHandle::Release((RTHandle *)v25.m128i_i64[0], 0LL);
			//             v28 = (List_1_System_Int32_ *)v5[1].monitor;
			//             if ( !Keys )
			//               sub_1802DC2C8(v27, v26);
			//             v29 = sub_180002FC0(0LL, TypeInfo::System::Collections::Generic::IList<int>, Keys, (unsigned int)i);
			//             if ( !v28 )
			//               sub_1802DC2C8(v31, v30);
			//             sub_18231EF50(v28, v29);
			//           }
			//         }
			//         v32 = (OneofDescriptor__Class *)v5[1].monitor;
			//         if ( !v32 )
			//           sub_1802DC2C8(v20, v19);
			//         *(_OWORD *)&v38.monitor = 0LL;
			//         v38.klass = v32;
			//         ((void (__stdcall *)(OneofDescriptor *, OneofDescriptorProto *, FileDescriptor *, MessageDescriptor *, String__Array *, String *))sub_1800054D0)(
			//           &v38,
			//           v19,
			//           v21,
			//           (MessageDescriptor *)v32,
			//           v35,
			//           v37);
			//         LODWORD(v38.monitor) = 0;
			//         HIDWORD(v38.monitor) = *(_DWORD *)(v33 + 28);
			//         v38.fields._._Index_k__BackingField = 0;
			//         *(_OWORD *)&v38.fields.containingType = *(_OWORD *)&v38.klass;
			//         v38.fields.accessor = *(OneofAccessor **)&v38.fields._._Index_k__BackingField;
			//         v38.fields._Proto_k__BackingField = 0LL;
			//         *(_QWORD *)&v38.fields._IsSynthetic_k__BackingField = &v38.fields.containingType;
			//         try
			//         {
			//           while ( System::Collections::Generic::List_1_T_::Enumerator<unsigned int>::MoveNext(
			//                     (List_1_T_Enumerator_System_UInt32_ *)&v38.fields.containingType,
			//                     MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext) )
			//             System::Collections::Generic::SortedList<int,System::ValueTuple<System::Object,int>>::Remove(
			//               (SortedList_2_System_Int32_System_ValueTuple_2_Object_Int32_ *)value,
			//               (int32_t)v38.fields.accessor,
			//               MethodInfo::System::Collections::Generic::SortedList<int,System::ValueTuple<UnityEngine::Rendering::RTHandle,int>>::Remove);
			//         }
			//         catch ( Il2CppExceptionWrapper *v42 )
			//         {
			//           v38.fields._Proto_k__BackingField = (OneofDescriptorProto *)v42.ex;
			//           if ( v38.fields._Proto_k__BackingField )
			//             sub_18000F780(v38.fields._Proto_k__BackingField);
			//           v5 = (Object *)this;
			//         }
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v43 )
			//     {
			//       ex = v43.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//     }
			//   }
			// }
			// 
		}
	}
}
