using System;
using Unity.Mathematics;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class CompressedInt2Array
	{
		public CompressedInt2Array()
		{
			// // CompressedInt2Array()
			// void HG::Rendering::Runtime::CompressedInt2Array::CompressedInt2Array(CompressedInt2Array *this, MethodInfo *method)
			// {
			//   DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   DynamicArray_1_Unity_Mathematics_int4_ *v6; // rbx
			//   OneofDescriptorProto *v7; // rdx
			//   FileDescriptor *v8; // r8
			//   MessageDescriptor *v9; // r9
			//   String__Array *v10; // [rsp+50h] [rbp+28h]
			//   String *v11; // [rsp+58h] [rbp+30h]
			//   MethodInfo *v12; // [rsp+60h] [rbp+38h]
			// 
			//   if ( !byte_18D919CE1 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<Unity::Mathematics::int4>::DynamicArray);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::DynamicArray<Unity::Mathematics::int4>);
			//     byte_18D919CE1 = 1;
			//   }
			//   v3 = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)sub_180004920(TypeInfo::UnityEngine::Rendering::DynamicArray<Unity::Mathematics::int4>);
			//   v6 = (DynamicArray_1_Unity_Mathematics_int4_ *)v3;
			//   if ( !v3 )
			//     sub_180B536AC(v5, v4);
			//   UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::DynamicArray(
			//     v3,
			//     MethodInfo::UnityEngine::Rendering::DynamicArray<Unity::Mathematics::int4>::DynamicArray);
			//   this.fields.arrayData = v6;
			//   sub_1800054D0((OneofDescriptor *)&this.fields, v7, v8, v9, v10, v11, v12);
			// }
			// 
		}

		public void Add(int ele0, int ele1)
		{
			// // Void Add(Int32, Int32)
			// void HG::Rendering::Runtime::CompressedInt2Array::Add(
			//         CompressedInt2Array *this,
			//         int32_t ele0,
			//         int32_t ele1,
			//         MethodInfo *method)
			// {
			//   DynamicArray_1_Unity_Mathematics_int4_ *v7; // rdx
			//   DynamicArray_1_Unity_Mathematics_int4_ *arrayData; // rcx
			//   int4 *Item; // rax
			//   __m128i v10; // xmm0
			//   int32_t v11; // edx
			//   DynamicArray_1_Unity_Mathematics_int4_ *v12; // rcx
			//   bool v13; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   int4 value; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919CDF )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<Unity::Mathematics::int4>::Add);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<Unity::Mathematics::int4>::get_Item);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<Unity::Mathematics::int4>::get_size);
			//     byte_18D919CDF = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1124, 0LL) )
			//   {
			//     arrayData = this.fields.arrayData;
			//     if ( this.fields.m_isFlipped )
			//     {
			//       if ( arrayData )
			//       {
			//         Item = UnityEngine::Rendering::DynamicArray<Unity::Mathematics::int4>::get_Item(
			//                  arrayData,
			//                  arrayData.fields._size_k__BackingField - 1,
			//                  MethodInfo::UnityEngine::Rendering::DynamicArray<Unity::Mathematics::int4>::get_Item);
			//         v7 = this.fields.arrayData;
			//         v10 = *(__m128i *)Item;
			//         if ( v7 )
			//         {
			//           v11 = v7.fields._size_k__BackingField - 1;
			//           v12 = this.fields.arrayData;
			//           value.x = _mm_cvtsi128_si32(v10);
			//           value.y = _mm_cvtsi128_si32(_mm_srli_si128(v10, 4));
			//           value.z = ele0;
			//           value.w = ele1;
			//           *UnityEngine::Rendering::DynamicArray<Unity::Mathematics::int4>::get_Item(
			//              v12,
			//              v11,
			//              MethodInfo::UnityEngine::Rendering::DynamicArray<Unity::Mathematics::int4>::get_Item) = value;
			//           goto LABEL_10;
			//         }
			//       }
			//     }
			//     else
			//     {
			//       value.z = 0;
			//       value.w = 0;
			//       value.x = ele0;
			//       value.y = ele1;
			//       if ( arrayData )
			//       {
			//         UnityEngine::Rendering::DynamicArray<Unity::Mathematics::int4>::Add(
			//           arrayData,
			//           &value,
			//           MethodInfo::UnityEngine::Rendering::DynamicArray<Unity::Mathematics::int4>::Add);
			// LABEL_10:
			//         v13 = !this.fields.m_isFlipped;
			//         ++this.fields.count;
			//         this.fields.m_isFlipped = v13;
			//         return;
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(arrayData, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1124, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_56((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, ele0, ele1, 0LL);
			// }
			// 
		}

		public void AlignToInt4()
		{
			// // Void AlignToInt4()
			// void HG::Rendering::Runtime::CompressedInt2Array::AlignToInt4(CompressedInt2Array *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1125, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1125, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( this.fields.m_isFlipped )
			//   {
			//     HG::Rendering::Runtime::CompressedInt2Array::Add(this, 0, 0, 0LL);
			//   }
			// }
			// 
		}

		public void Reset()
		{
			// // Void Reset()
			// void HG::Rendering::Runtime::CompressedInt2Array::Reset(CompressedInt2Array *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   DynamicArray_1_Unity_Mathematics_int4_ *arrayData; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919CE0 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<Unity::Mathematics::int4>::Clear);
			//     byte_18D919CE0 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1126, 0LL) )
			//   {
			//     arrayData = this.fields.arrayData;
			//     if ( arrayData )
			//     {
			//       UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Clear(
			//         (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)arrayData,
			//         MethodInfo::UnityEngine::Rendering::DynamicArray<Unity::Mathematics::int4>::Clear);
			//       this.fields.count = 0;
			//       this.fields.m_isFlipped = 0;
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(arrayData, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1126, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public DynamicArray<int4> arrayData;

		public int count;

		private bool m_isFlipped;
	}
}
