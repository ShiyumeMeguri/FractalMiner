using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal struct ClothConstData // TypeDefIndex: 37556
	{
		// Fields
		public Vector4 packedDeltaT; // 0x00
		public Vector4 clothParam1; // 0x10
		public unsafe fixed /* 0x00000000-0x00000000 */ float colliderInfoArray[0]; // 0x20
	
		// Methods
		public void SetDt(float dt) {} // 0x0000000189C673AC-0x0000000189C67418
		// Void SetDt(Single)
		void HG::Rendering::Runtime::ClothConstData::SetDt(ClothConstData *this, float dt, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1246, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1246, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_474(Patch, this, dt, 0LL);
		  }
		  else
		  {
		    this->packedDeltaT.x = dt;
		    this->packedDeltaT.z = 1.0 / dt;
		  }
		}
		
		public void SetSkeletonFlipped(float flipped) {} // 0x0000000189C67474-0x0000000189C674D0
		// Void SetSkeletonFlipped(Single)
		void HG::Rendering::Runtime::ClothConstData::SetSkeletonFlipped(
		        ClothConstData *this,
		        float flipped,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1247, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1247, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_474(Patch, this, flipped, 0LL);
		  }
		  else
		  {
		    this->packedDeltaT.y = flipped;
		  }
		}
		
		public void SetLoopNum(float loopNum) {} // 0x0000000189C67418-0x0000000189C67474
		// Void SetLoopNum(Single)
		void HG::Rendering::Runtime::ClothConstData::SetLoopNum(ClothConstData *this, float loopNum, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1248, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1248, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_474(Patch, this, loopNum, 0LL);
		  }
		  else
		  {
		    this->packedDeltaT.w = loopNum;
		  }
		}
		
		public void SetClothWindParams(float windTime, Vector2 windNoiseUV) {} // 0x0000000189C6731C-0x0000000189C673AC
		// Void SetClothWindParams(Single, Vector2)
		void HG::Rendering::Runtime::ClothConstData::SetClothWindParams(
		        ClothConstData *this,
		        float windTime,
		        Vector2 windNoiseUV,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1249, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1249, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_475(Patch, this, windTime, windNoiseUV, 0LL);
		  }
		  else
		  {
		    this->clothParam1.x = windTime;
		    *(Vector2 *)&this->clothParam1.y = windNoiseUV;
		  }
		}
		
		public void SetVec4(int vecIdx, Vector4 vec4) {} // 0x000000018323C3C0-0x000000018323C470
		// Void SetVec4(Int32, Vector4)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::Runtime::ClothConstData::SetVec4(
		        ClothConstData *this,
		        int32_t vecIdx,
		        Vector4 *vec4,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 1250 )
		  {
		LABEL_5:
		    *((_DWORD *)&this->colliderInfoArray.FixedElementField + 4 * vecIdx) = LODWORD(vec4->x);
		    *((_DWORD *)&this[1].packedDeltaT.x + 4 * vecIdx) = LODWORD(vec4->y);
		    *((_DWORD *)&this[1].packedDeltaT.y + 4 * vecIdx) = LODWORD(vec4->z);
		    *((_DWORD *)&this[1].packedDeltaT.z + 4 * vecIdx) = LODWORD(vec4->w);
		    return;
		  }
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		  if ( !v6 )
		    goto LABEL_6;
		  if ( LODWORD(v6->_0.namespaze) <= 0x4E2 )
		    sub_1800D2AB0(v6, *(_QWORD *)&vecIdx);
		  if ( !*(_QWORD *)&v6[26]._1.element_size )
		    goto LABEL_5;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1250, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v6, *(_QWORD *)&vecIdx);
		  v10 = *vec4;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_476(Patch, this, vecIdx, &v10, 0LL);
		}
		
		public Vector4 GetVec4(int vecIdx) => default; // 0x000000018323BA50-0x000000018323BB30
		// Vector4 GetVec4(Int32)
		Vector4 *HG::Rendering::Runtime::ClothConstData::GetVec4(
		        Vector4 *__return_ptr retstr,
		        ClothConstData *this,
		        int32_t vecIdx,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  __m128 v9; // xmm3
		  __m128 v10; // xmm3
		  __m128 v11; // xmm3
		  __m128 v12; // xmm3
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v15; // [rsp+30h] [rbp-18h] BYREF
		
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 1251 )
		  {
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		    if ( v6 )
		    {
		      if ( LODWORD(v6->_0.namespaze) <= 0x4E3 )
		        sub_1800D2AB0(v6, this);
		      if ( !*(_QWORD *)&v6[26]._1.static_fields_size )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(1251, 0LL);
		      if ( Patch )
		      {
		        *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_477(&v15, Patch, this, vecIdx, 0LL);
		        return retstr;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v6, this);
		  }
		LABEL_5:
		  v9 = (__m128)*((unsigned int *)&this->colliderInfoArray.FixedElementField + 4 * vecIdx);
		  v10 = _mm_shuffle_ps(v9, v9, 225);
		  v10.m128_f32[0] = *(&this[1].packedDeltaT.x + 4 * vecIdx);
		  v11 = _mm_shuffle_ps(v10, v10, 198);
		  v11.m128_f32[0] = *(&this[1].packedDeltaT.y + 4 * vecIdx);
		  v12 = _mm_shuffle_ps(v11, v11, 39);
		  v12.m128_f32[0] = *(&this[1].packedDeltaT.z + 4 * vecIdx);
		  *(__m128 *)retstr = _mm_shuffle_ps(v12, v12, 57);
		  return retstr;
		}
		
		public void SetSingleFloat(int vecIdx, int floatIdx, float value) {} // 0x000000018323D680-0x000000018323D710
		// Void SetSingleFloat(Int32, Int32, Single)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::Runtime::ClothConstData::SetSingleFloat(
		        ClothConstData *this,
		        int32_t vecIdx,
		        int32_t floatIdx,
		        float value,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 1252 )
		  {
		LABEL_5:
		    *(&this->colliderInfoArray.FixedElementField + 4 * vecIdx + floatIdx) = value;
		    return;
		  }
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		  if ( !v6 )
		    goto LABEL_6;
		  if ( LODWORD(v6->_0.namespaze) <= 0x4E4 )
		    sub_1800D2AB0(v6, *(_QWORD *)&vecIdx);
		  if ( !*(_QWORD *)&v6[26]._1.thread_static_fields_offset )
		    goto LABEL_5;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1252, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v6, *(_QWORD *)&vecIdx);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_478(Patch, this, vecIdx, floatIdx, value, 0LL);
		}
		
		public float GetSingleFloat(int vecIdx, int floatIdx) => default; // 0x000000018323D600-0x000000018323D680
		// Single GetSingleFloat(Int32, Int32)
		// local variable allocation has failed, the output may be wrong!
		float HG::Rendering::Runtime::ClothConstData::GetSingleFloat(
		        ClothConstData *this,
		        int32_t vecIdx,
		        int32_t floatIdx,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 1253 )
		    return *(&this->colliderInfoArray.FixedElementField + 4 * vecIdx + floatIdx);
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		  if ( !v6 )
		    goto LABEL_6;
		  if ( LODWORD(v6->_0.namespaze) <= 0x4E5 )
		    sub_1800D2AB0(v6, *(_QWORD *)&vecIdx);
		  if ( !*(_QWORD *)&v6[26]._1.token )
		    return *(&this->colliderInfoArray.FixedElementField + 4 * vecIdx + floatIdx);
		  Patch = IFix::WrappersManagerImpl::GetPatch(1253, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v6, *(_QWORD *)&vecIdx);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_479(Patch, this, vecIdx, floatIdx, 0LL);
		}
		
	}
}
