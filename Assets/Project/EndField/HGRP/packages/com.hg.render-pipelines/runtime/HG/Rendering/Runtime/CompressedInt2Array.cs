using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class CompressedInt2Array // TypeDefIndex: 37561
	{
		// Fields
		public DynamicArray<int4> arrayData; // 0x10
		public int count; // 0x18
		private bool m_isFlipped; // 0x1C
	
		// Constructors
		public CompressedInt2Array() {} // 0x0000000189C68DF8-0x0000000189C68E48
		// CompressedInt2Array()
		void HG::Rendering::Runtime::CompressedInt2Array::CompressedInt2Array(CompressedInt2Array *this, MethodInfo *method)
		{
		  DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  DynamicArray_1_Unity_Mathematics_int4_ *v6; // rbx
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  v3 = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)sub_18002C620(TypeInfo::UnityEngine::Rendering::DynamicArray<Unity::Mathematics::int4>);
		  v6 = (DynamicArray_1_Unity_Mathematics_int4_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::DynamicArray(
		    v3,
		    MethodInfo::UnityEngine::Rendering::DynamicArray<Unity::Mathematics::int4>::DynamicArray);
		  this->fields.arrayData = v6;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v7, v8, v9, v10);
		}
		
	
		// Methods
		public void Add(int ele0, int ele1) {} // 0x0000000189C68C1C-0x0000000189C68D30
		// Void Add(Int32, Int32)
		void HG::Rendering::Runtime::CompressedInt2Array::Add(
		        CompressedInt2Array *this,
		        int32_t ele0,
		        int32_t ele1,
		        MethodInfo *method)
		{
		  DynamicArray_1_Unity_Mathematics_int4_ *v7; // rdx
		  DynamicArray_1_Unity_Mathematics_int4_ *arrayData; // rcx
		  NativeArray_1_System_Single_ *Ref; // rax
		  __m128i v10; // xmm0
		  int32_t v11; // edx
		  IndexedArray_1_Unity_Collections_NativeArray_1_System_Single_ *v12; // rcx
		  bool v13; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  int4 value; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1260, 0LL) )
		  {
		    arrayData = this->fields.arrayData;
		    if ( this->fields.m_isFlipped )
		    {
		      if ( arrayData )
		      {
		        Ref = Beyond::Gameplay::Core::DynamicScene::IndexedArray<Unity::Collections::NativeArray<float>>::GetRef(
		                (IndexedArray_1_Unity_Collections_NativeArray_1_System_Single_ *)arrayData,
		                arrayData->fields._size_k__BackingField - 1,
		                MethodInfo::UnityEngine::Rendering::DynamicArray<Unity::Mathematics::int4>::get_Item);
		        v7 = this->fields.arrayData;
		        v10 = *(__m128i *)Ref;
		        if ( v7 )
		        {
		          v11 = v7->fields._size_k__BackingField - 1;
		          v12 = (IndexedArray_1_Unity_Collections_NativeArray_1_System_Single_ *)this->fields.arrayData;
		          value.x = _mm_cvtsi128_si32(v10);
		          value.y = _mm_cvtsi128_si32(_mm_srli_si128(v10, 4));
		          value.z = ele0;
		          value.w = ele1;
		          *(int4 *)Beyond::Gameplay::Core::DynamicScene::IndexedArray<Unity::Collections::NativeArray<float>>::GetRef(
		                     v12,
		                     v11,
		                     MethodInfo::UnityEngine::Rendering::DynamicArray<Unity::Mathematics::int4>::get_Item) = value;
		          goto LABEL_8;
		        }
		      }
		    }
		    else
		    {
		      value.z = 0;
		      value.w = 0;
		      value.x = ele0;
		      value.y = ele1;
		      if ( arrayData )
		      {
		        UnityEngine::Rendering::DynamicArray<Unity::Mathematics::int4>::Add(
		          arrayData,
		          &value,
		          MethodInfo::UnityEngine::Rendering::DynamicArray<Unity::Mathematics::int4>::Add);
		LABEL_8:
		        v13 = !this->fields.m_isFlipped;
		        ++this->fields.count;
		        this->fields.m_isFlipped = v13;
		        return;
		      }
		    }
		LABEL_10:
		    sub_1800D8260(arrayData, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1260, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_272(
		    (ILFixDynamicMethodWrapper_6 *)Patch,
		    (Object *)this,
		    (UIInertiaViewPager_State__Enum)ele0,
		    (UIInertiaViewPager_State__Enum)ele1,
		    0LL);
		}
		
		public void AlignToInt4() {} // 0x0000000189C68D30-0x0000000189C68D90
		// Void AlignToInt4()
		void HG::Rendering::Runtime::CompressedInt2Array::AlignToInt4(CompressedInt2Array *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1261, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1261, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( this->fields.m_isFlipped )
		  {
		    HG::Rendering::Runtime::CompressedInt2Array::Add(this, 0, 0, 0LL);
		  }
		}
		
		public void Reset() {} // 0x0000000189C68D90-0x0000000189C68DF8
		// Void Reset()
		void HG::Rendering::Runtime::CompressedInt2Array::Reset(CompressedInt2Array *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  DynamicArray_1_Unity_Mathematics_int4_ *arrayData; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1262, 0LL) )
		  {
		    arrayData = this->fields.arrayData;
		    if ( arrayData )
		    {
		      UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Clear(
		        (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)arrayData,
		        MethodInfo::UnityEngine::Rendering::DynamicArray<Unity::Mathematics::int4>::Clear);
		      this->fields.count = 0;
		      this->fields.m_isFlipped = 0;
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(arrayData, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1262, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
