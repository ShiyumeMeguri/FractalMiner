using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 224)]
	internal struct ClothConstData
	{
		public void SetDt(float dt)
		{
			// // Void SetDt(Single)
			// void HG::Rendering::Runtime::ClothConstData::SetDt(ClothConstData *this, float dt, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1110, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1110, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_405(Patch, this, dt, 0LL);
			//   }
			//   else
			//   {
			//     this.packedDeltaT.x = dt;
			//     this.packedDeltaT.z = 1.0 / dt;
			//   }
			// }
			// 
		}

		public void SetSkeletonFlipped(float flipped)
		{
			// // Void SetSkeletonFlipped(Single)
			// void HG::Rendering::Runtime::ClothConstData::SetSkeletonFlipped(
			//         ClothConstData *this,
			//         float flipped,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1111, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1111, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_405(Patch, this, flipped, 0LL);
			//   }
			//   else
			//   {
			//     this.packedDeltaT.y = flipped;
			//   }
			// }
			// 
		}

		public void SetLoopNum(float loopNum)
		{
			// // Void SetLoopNum(Single)
			// void HG::Rendering::Runtime::ClothConstData::SetLoopNum(ClothConstData *this, float loopNum, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1112, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1112, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_405(Patch, this, loopNum, 0LL);
			//   }
			//   else
			//   {
			//     this.packedDeltaT.w = loopNum;
			//   }
			// }
			// 
		}

		public void SetClothWindParams(float windTime, Vector2 windNoiseUV)
		{
			// // Void SetClothWindParams(Single, Vector2)
			// void HG::Rendering::Runtime::ClothConstData::SetClothWindParams(
			//         ClothConstData *this,
			//         float windTime,
			//         Vector2 windNoiseUV,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1113, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1113, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_406(Patch, this, windTime, windNoiseUV, 0LL);
			//   }
			//   else
			//   {
			//     this.clothParam1.x = windTime;
			//     *(Vector2 *)&this.clothParam1.y = windNoiseUV;
			//   }
			// }
			// 
		}

		public void SetVec4(int vecIdx, Vector4 vec4)
		{
			// // Void SetVec4(Int32, Vector4)
			// // local variable allocation has failed, the output may be wrong!
			// void HG::Rendering::Runtime::ClothConstData::SetVec4(
			//         ClothConstData *this,
			//         int32_t vecIdx,
			//         Vector4 *vec4,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, *(_QWORD *)&vecIdx);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_8;
			//   if ( wrapperArray.max_length.size <= 1114 )
			//   {
			// LABEL_7:
			//     *((_DWORD *)&this.colliderInfoArray.FixedElementField + 4 * vecIdx) = LODWORD(vec4.x);
			//     *((_DWORD *)&this[1].packedDeltaT.x + 4 * vecIdx) = LODWORD(vec4.y);
			//     *((_DWORD *)&this[1].packedDeltaT.y + 4 * vecIdx) = LODWORD(vec4.z);
			//     *((_DWORD *)&this[1].packedDeltaT.z + 4 * vecIdx) = LODWORD(vec4.w);
			//     return;
			//   }
			//   if ( !v7._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v7, wrapperArray);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v7 = (struct ILFixDynamicMethodWrapper_2__Class *)v7.static_fields.wrapperArray;
			//   if ( !v7 )
			//     goto LABEL_8;
			//   if ( LODWORD(v7._0.namespaze) <= 0x45A )
			//     sub_180070270(v7, wrapperArray);
			//   if ( !*(_QWORD *)&v7[23]._1.interfaces_count )
			//     goto LABEL_7;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1114, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(v7, wrapperArray);
			//   v10 = *vec4;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_407(Patch, this, vecIdx, &v10, 0LL);
			// }
			// 
		}

		public Vector4 GetVec4(int vecIdx)
		{
			// // Vector4 GetVec4(Int32)
			// Vector4 *HG::Rendering::Runtime::ClothConstData::GetVec4(
			//         Vector4 *__return_ptr retstr,
			//         ClothConstData *this,
			//         int32_t vecIdx,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   __m128 v9; // xmm3
			//   __m128 v10; // xmm3
			//   __m128 v11; // xmm3
			//   __m128 v12; // xmm3
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v15; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 1115 )
			//   {
			//     if ( !v7._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v7, wrapperArray);
			//       v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v7 = (struct ILFixDynamicMethodWrapper_2__Class *)v7.static_fields.wrapperArray;
			//     if ( v7 )
			//     {
			//       if ( LODWORD(v7._0.namespaze) <= 0x45B )
			//         sub_180070270(v7, wrapperArray);
			//       if ( !*(_QWORD *)&v7[23]._1.naturalAligment )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1115, 0LL);
			//       if ( Patch )
			//       {
			//         *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_408(&v15, Patch, this, vecIdx, 0LL);
			//         return retstr;
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(v7, wrapperArray);
			//   }
			// LABEL_7:
			//   v9 = (__m128)*((unsigned int *)&this.colliderInfoArray.FixedElementField + 4 * vecIdx);
			//   v10 = _mm_shuffle_ps(v9, v9, 225);
			//   v10.m128_f32[0] = *(&this[1].packedDeltaT.x + 4 * vecIdx);
			//   v11 = _mm_shuffle_ps(v10, v10, 198);
			//   v11.m128_f32[0] = *(&this[1].packedDeltaT.y + 4 * vecIdx);
			//   v12 = _mm_shuffle_ps(v11, v11, 39);
			//   v12.m128_f32[0] = *(&this[1].packedDeltaT.z + 4 * vecIdx);
			//   *(__m128 *)retstr = _mm_shuffle_ps(v12, v12, 57);
			//   return retstr;
			// }
			// 
			return null;
		}

		public void SetSingleFloat(int vecIdx, int floatIdx, float value)
		{
			// // Void SetSingleFloat(Int32, Int32, Single)
			// // local variable allocation has failed, the output may be wrong!
			// void HG::Rendering::Runtime::ClothConstData::SetSingleFloat(
			//         ClothConstData *this,
			//         int32_t vecIdx,
			//         int32_t floatIdx,
			//         float value,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v8; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, *(_QWORD *)&vecIdx);
			//     v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v8.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_8;
			//   if ( wrapperArray.max_length.size <= 1116 )
			//   {
			// LABEL_7:
			//     *(&this.colliderInfoArray.FixedElementField + 4 * vecIdx + floatIdx) = value;
			//     return;
			//   }
			//   if ( !v8._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v8, wrapperArray);
			//     v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v8 = (struct ILFixDynamicMethodWrapper_2__Class *)v8.static_fields.wrapperArray;
			//   if ( !v8 )
			//     goto LABEL_8;
			//   if ( LODWORD(v8._0.namespaze) <= 0x45C )
			//     sub_180070270(v8, wrapperArray);
			//   if ( !v8[23].vtable.Equals.methodPtr )
			//     goto LABEL_7;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1116, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(v8, wrapperArray);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_409(Patch, this, vecIdx, floatIdx, value, 0LL);
			// }
			// 
		}

		public float GetSingleFloat(int vecIdx, int floatIdx)
		{
			// // Single GetSingleFloat(Int32, Int32)
			// // local variable allocation has failed, the output may be wrong!
			// float HG::Rendering::Runtime::ClothConstData::GetSingleFloat(
			//         ClothConstData *this,
			//         int32_t vecIdx,
			//         int32_t floatIdx,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, *(_QWORD *)&vecIdx);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_8;
			//   if ( wrapperArray.max_length.size <= 1117 )
			//     return *(&this.colliderInfoArray.FixedElementField + 4 * vecIdx + floatIdx);
			//   if ( !v7._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v7, wrapperArray);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v7 = (struct ILFixDynamicMethodWrapper_2__Class *)v7.static_fields.wrapperArray;
			//   if ( !v7 )
			//     goto LABEL_8;
			//   if ( LODWORD(v7._0.namespaze) <= 0x45D )
			//     sub_180070270(v7, wrapperArray);
			//   if ( !v7[23].vtable.Equals.method )
			//     return *(&this.colliderInfoArray.FixedElementField + 4 * vecIdx + floatIdx);
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1117, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(v7, wrapperArray);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_410(Patch, this, vecIdx, floatIdx, 0LL);
			// }
			// 
			return 0f;
		}

		public Vector4 packedDeltaT;

		public Vector4 clothParam1;

		[FixedBuffer(typeof(float), 48)]
		public ClothConstData.<colliderInfoArray>e__FixedBuffer colliderInfoArray;

		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 192)]
		public struct <colliderInfoArray>e__FixedBuffer
		{
			public float FixedElementField;
		}
	}
}
