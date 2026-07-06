using System;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public static class GpuClothUtils
	{
		public unsafe static void ResizeAndCopy<T>(DynamicArray<T> dstArray, byte* srcArray, int srcArraySize) where T : struct
		{
		}

		public unsafe static void ResizeAndCopy<T>(NativeList<T> dstArray, byte* srcArray, int srcArraySize, int offset, int size) where T : struct
		{
		}

		public static void ResizeAndCopy<T>(NativeList<T> dstArray, DynamicArray<T> srcArray) where T : struct
		{
		}

		public static void RemoveTail<T>(this DynamicArray<T> dynamicArray, int count) where T : new()
		{
		}

		public static T Last<T>(this DynamicArray<T> dynamicArray) where T : new()
		{
			return null;
		}

		public static void SwapAndRemove<T>(this DynamicArray<T> dynamicArray, int idx) where T : new()
		{
		}

		public static void SwapAndRemoveBytes(this DynamicArray<byte> dynamicArray, int idx, int count)
		{
			// // Void SwapAndRemoveBytes(DynamicArray`1[System.Byte], Int32, Int32)
			// void HG::Rendering::Runtime::GpuClothUtils::SwapAndRemoveBytes(
			//         DynamicArray_1_System_Byte_ *dynamicArray,
			//         int32_t idx,
			//         int32_t count,
			//         MethodInfo *method)
			// {
			//   int64_t v5; // rsi
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   int32_t v9; // edx
			//   uint8_t *Item; // rbx
			//   uint8_t *v11; // rax
			//   __int64 v12; // rax
			//   ArgumentOutOfRangeException *v13; // rax
			//   ArgumentOutOfRangeException *v14; // rbx
			//   __int64 v15; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   v5 = count;
			//   if ( !byte_18D91974C )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<unsigned char>::get_Item);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<unsigned char>::get_size);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RemoveTail<unsigned char>);
			//     byte_18D91974C = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3450, 0LL) )
			//   {
			//     if ( dynamicArray )
			//     {
			//       v9 = dynamicArray.fields._size_k__BackingField - v5;
			//       if ( idx == v9 )
			//       {
			// LABEL_9:
			//         HG::Rendering::Runtime::GpuClothUtils::RemoveTail<System::Object>(
			//           (DynamicArray_1_System_Object_ *)dynamicArray,
			//           v5,
			//           MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RemoveTail<unsigned char>);
			//         return;
			//       }
			//       if ( v9 >= 0 && idx + (int)v5 <= v9 )
			//       {
			//         Item = UnityEngine::Rendering::DynamicArray<unsigned char>::get_Item(
			//                  dynamicArray,
			//                  v9,
			//                  MethodInfo::UnityEngine::Rendering::DynamicArray<unsigned char>::get_Item);
			//         v11 = UnityEngine::Rendering::DynamicArray<unsigned char>::get_Item(
			//                 dynamicArray,
			//                 idx,
			//                 MethodInfo::UnityEngine::Rendering::DynamicArray<unsigned char>::get_Item);
			//         Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy((Void *)v11, (Void *)Item, v5, 0LL);
			//         goto LABEL_9;
			//       }
			//       v12 = sub_18000F7E0(&TypeInfo::System::ArgumentOutOfRangeException);
			//       v13 = (ArgumentOutOfRangeException *)sub_180004920(v12);
			//       v14 = v13;
			//       if ( v13 )
			//       {
			//         System::ArgumentOutOfRangeException::ArgumentOutOfRangeException(v13, 0LL);
			//         v15 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::GpuClothUtils::SwapAndRemoveBytes);
			//         sub_18000F7C0(v14, v15);
			//       }
			//     }
			// LABEL_13:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3450, 0LL);
			//   if ( !Patch )
			//     goto LABEL_13;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_56(
			//     (ILFixDynamicMethodWrapper_20 *)Patch,
			//     (Object *)dynamicArray,
			//     idx,
			//     v5,
			//     0LL);
			// }
			// 
		}

		public static NativeArray<T> ConvertToNativeArray<T>(DynamicArray<byte> dynamicArray) where T : struct
		{
			return null;
		}

		public static NativeArray<T> ConvertToNativeArray<T>(DynamicArray<T> dynamicArray) where T : struct
		{
			return null;
		}

		public static byte[] ConvertToBytes<T>(this DynamicArray<T> dynamicArray) where T : struct
		{
			return null;
		}

		public static void ResizeComputeBuffer(ref ComputeBuffer computeBuffer, int stride, int count)
		{
			// // Void ResizeComputeBuffer(ComputeBuffer ByRef, Int32, Int32)
			// void HG::Rendering::Runtime::GpuClothUtils::ResizeComputeBuffer(
			//         ComputeBuffer **computeBuffer,
			//         int32_t stride,
			//         int32_t count,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   ComputeBuffer *v8; // rcx
			//   ComputeBuffer *v9; // rax
			//   ComputeBuffer *v10; // rdi
			//   OneofDescriptorProto *v11; // rdx
			//   FileDescriptor *v12; // r8
			//   MessageDescriptor *v13; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   String__Array *v15; // [rsp+20h] [rbp-18h]
			//   String *v16; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v17; // [rsp+30h] [rbp-8h]
			// 
			//   if ( !byte_18D91974D )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::ComputeBuffer);
			//     byte_18D91974D = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1156, 0LL) )
			//   {
			//     if ( *computeBuffer && UnityEngine::ComputeBuffer::IsValid(*computeBuffer, 0LL) )
			//     {
			//       v8 = *computeBuffer;
			//       if ( !*computeBuffer )
			//         goto LABEL_15;
			//       if ( UnityEngine::ComputeBuffer::get_stride(v8, 0LL) == stride )
			//       {
			//         v8 = *computeBuffer;
			//         if ( !*computeBuffer )
			//           goto LABEL_15;
			//         if ( UnityEngine::ComputeBuffer::get_count(v8, 0LL) >= count )
			//           return;
			//       }
			//       v8 = *computeBuffer;
			//       if ( !*computeBuffer )
			// LABEL_15:
			//         sub_180B536AC(v8, v7);
			//       UnityEngine::ComputeBuffer::Dispose(v8, 0LL);
			//     }
			//     v9 = (ComputeBuffer *)sub_180004920(TypeInfo::UnityEngine::ComputeBuffer);
			//     v10 = v9;
			//     if ( v9 )
			//     {
			//       UnityEngine::ComputeBuffer::ComputeBuffer(v9, count, stride, 0LL);
			//       *computeBuffer = v10;
			//       sub_1800054D0((OneofDescriptor *)computeBuffer, v11, v12, v13, v15, v16, v17);
			//       return;
			//     }
			//     goto LABEL_15;
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1156, 0LL);
			//   if ( !Patch )
			//     goto LABEL_15;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_428(Patch, computeBuffer, stride, count, 0LL);
			// }
			// 
		}

		public static float GetClothAnimationWindIntensity(float windIntensity, float transformScale)
		{
			// // Single GetClothAnimationWindIntensity(Single, Single)
			// float HG::Rendering::Runtime::GpuClothUtils::GetClothAnimationWindIntensity(
			//         float windIntensity,
			//         float transformScale,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3451, 0LL) )
			//     return (float)(windIntensity * 0.16) * transformScale;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3451, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_359(
			//            (ILFixDynamicMethodWrapper_3 *)Patch,
			//            windIntensity,
			//            transformScale,
			//            0LL);
			// }
			// 
			return 0f;
		}

		public static float GetClothAnimationWindFreq(float clothAnimationWindIntensity)
		{
			// // Single GetClothAnimationWindFreq(Single)
			// float HG::Rendering::Runtime::GpuClothUtils::GetClothAnimationWindFreq(
			//         float clothAnimationWindIntensity,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3452, 0LL) )
			//     return (float)((float)(clothAnimationWindIntensity * 0.69999999) + 1.0) * 25.0;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3452, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v5, v4);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_59(
			//            (ILFixDynamicMethodWrapper_7 *)Patch,
			//            clothAnimationWindIntensity,
			//            0LL);
			// }
			// 
			return 0f;
		}

		public static void RecycleNativeDataStructs<T>(ref NativeParallelHashSet<T> data) where T : struct, IEquatable<T>
		{
		}

		public static void RecycleNativeDataStructs<K, V>(ref NativeParallelHashMap<K, V> data) where K : struct, IEquatable<K> where V : struct
		{
		}

		public static void RecycleNativeDataStructs<T>(ref NativeList<T> data) where T : struct
		{
		}
	}
}
