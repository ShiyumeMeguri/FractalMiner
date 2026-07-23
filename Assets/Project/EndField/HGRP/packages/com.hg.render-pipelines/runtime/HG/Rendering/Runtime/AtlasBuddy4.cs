using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class AtlasBuddy4 // TypeDefIndex: 38074
	{
		// Fields
		private readonly int m_resolution; // 0x10
		private readonly int m_resOrder; // 0x14
		private readonly FreeArea[] m_freeArea; // 0x18
		private readonly byte[] m_buddyStatusMap; // 0x20
	
		// Properties
		private static ReadOnlySpan<byte> Log2DeBruijn { get => default; } // 0x0000000189B673C8-0x0000000189B6743C 
		// ReadOnlySpan`1[Byte] get_Log2DeBruijn()
		ReadOnlySpan_1_Byte_ *HG::Rendering::Runtime::AtlasBuddy4::get_Log2DeBruijn(
		        ReadOnlySpan_1_Byte_ *__return_ptr retstr,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ReadOnlySpan_1_Byte_ v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2713, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2713, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_992(&v7, Patch, 0LL);
		  }
		  else
		  {
		    *retstr = 0LL;
		    sub_1835633F0(
		      retstr,
		      4BCD43D478B9229AB7A13406353712C7944B60348C36B4D0E6B789D10F697652_FieldRva,
		      32LL,
		      MethodInfo::System::ReadOnlySpan<unsigned char>::ReadOnlySpan);
		  }
		  return retstr;
		}
		
	
		// Nested types
		private struct FreeArea // TypeDefIndex: 38073
		{
			// Fields
			public LinkedList<int> freePageId; // 0x00
			public int statusMapOffset; // 0x08
		}
	
		// Constructors
		public AtlasBuddy4() {} // Dummy constructor
		public AtlasBuddy4(int atlasResolution, int maxImageResolution) {} // 0x0000000189B671BC-0x0000000189B673C8
		// AtlasBuddy4(Int32, Int32)
		void HG::Rendering::Runtime::AtlasBuddy4::AtlasBuddy4(
		        AtlasBuddy4 *this,
		        int32_t atlasResolution,
		        int32_t maxImageResolution,
		        MethodInfo *method)
		{
		  int32_t v7; // edi
		  int32_t v8; // eax
		  int v9; // r13d
		  int32_t v10; // r14d
		  Type *v11; // rdx
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  __int64 v14; // rdx
		  AtlasBuddy4_FreeArea__Array *v15; // rcx
		  unsigned int v16; // esi
		  int32_t v17; // edi
		  int i; // r12d
		  AtlasBuddy4_FreeArea__Array *m_freeArea; // rax
		  AtlasBuddy4_FreeArea__Array *v20; // r15
		  __int64 v21; // rbp
		  SingleFieldAccessor *v22; // rax
		  Type *v23; // rdx
		  PropertyInfo_1 *v24; // r8
		  Int32__Array **v25; // r9
		  __int64 v26; // rax
		  Type *v27; // rdx
		  PropertyInfo_1 *v28; // r8
		  Int32__Array **v29; // r9
		  int32_t v30; // edi
		  LinkedList_1_System_Int32_ *v31; // rbp
		  int32_t v32; // esi
		  Object *v33; // rbx
		  Object *v34; // rax
		  String *v35; // rax
		  MethodInfo *v36; // [rsp+20h] [rbp-38h]
		  MethodInfo *v37; // [rsp+20h] [rbp-38h]
		  int v38; // [rsp+20h] [rbp-38h]
		  int32_t v39; // [rsp+68h] [rbp+10h] BYREF
		
		  if ( HG::Rendering::Runtime::AtlasBuddy4::_IsValidEdge(atlasResolution, 0LL)
		    && HG::Rendering::Runtime::AtlasBuddy4::_IsValidEdge(maxImageResolution, 0LL)
		    && atlasResolution >= maxImageResolution )
		  {
		    v7 = atlasResolution >> 1;
		    this->fields.m_resolution = v7;
		    if ( v7 == 1 )
		      v8 = 0;
		    else
		      v8 = HG::Rendering::Runtime::AtlasBuddy4::_OrderOfEdge(v7, 0LL);
		    this->fields.m_resOrder = v8;
		    v9 = this->fields.m_resolution * this->fields.m_resolution;
		    v10 = maxImageResolution >> 1;
		    v36 = (MethodInfo *)(unsigned int)HG::Rendering::Runtime::AtlasBuddy4::_OrderOfEdge(maxImageResolution, 0LL);
		    this->fields.m_freeArea = (AtlasBuddy4_FreeArea__Array *)il2cpp_array_new_specific_1(
		                                                               TypeInfo::HG::Rendering::Runtime::AtlasBuddy4::FreeArea,
		                                                               v36);
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_freeArea, v11, v12, v13, v36);
		    v16 = 0;
		    v17 = 0;
		    for ( i = 2; ; i += 2 )
		    {
		      m_freeArea = this->fields.m_freeArea;
		      if ( !m_freeArea )
		        goto LABEL_20;
		      if ( v17 >= m_freeArea->max_length.size )
		        break;
		      v20 = this->fields.m_freeArea;
		      v21 = sub_18002C620(TypeInfo::System::Collections::Generic::LinkedList<int>);
		      if ( !v21 )
		        goto LABEL_20;
		      *(_QWORD *)sub_1803C0774(v20, v17) = v21;
		      v22 = (SingleFieldAccessor *)sub_1803C0774(v20, v17);
		      sub_18002D1B0(v22, v23, v24, v25, v37);
		      v15 = this->fields.m_freeArea;
		      if ( !v15 )
		        goto LABEL_20;
		      v26 = sub_1803C0774(v15, v17++);
		      v15 = (AtlasBuddy4_FreeArea__Array *)(i & 0x1F);
		      *(_DWORD *)(v26 + 8) = v16;
		      v16 += v9 >> (char)v15;
		    }
		    this->fields.m_buddyStatusMap = (Byte__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Byte, v16);
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_buddyStatusMap, v27, v28, v29, v37);
		    v15 = this->fields.m_freeArea;
		    if ( !v15 )
		LABEL_20:
		      sub_1800D8260(v15, v14);
		    v30 = 0;
		    v31 = *(LinkedList_1_System_Int32_ **)sub_1803C0774(v15, v38 - 1LL);
		    if ( this->fields.m_resolution > 0 )
		    {
		      while ( 1 )
		      {
		        v32 = 0;
		        if ( this->fields.m_resolution > 0 )
		          break;
		LABEL_18:
		        v30 += v10;
		        if ( v30 >= this->fields.m_resolution )
		          return;
		      }
		      while ( v31 )
		      {
		        System::Collections::Generic::LinkedList<int>::AddLast(
		          v31,
		          v30 + (v32 << (this->fields.m_resOrder & 0x1F)),
		          MethodInfo::System::Collections::Generic::LinkedList<int>::AddLast);
		        v32 += v10;
		        if ( v32 >= this->fields.m_resolution )
		          goto LABEL_18;
		      }
		      goto LABEL_20;
		    }
		  }
		  else
		  {
		    v39 = atlasResolution;
		    v33 = (Object *)il2cpp_value_box_0(TypeInfo::System::Int32, &v39);
		    v39 = maxImageResolution;
		    v34 = (Object *)il2cpp_value_box_0(TypeInfo::System::Int32, &v39);
		    v35 = System::String::Format((String *)"Unsupported Atlas size: {0} or max image size: {1}.", v33, v34, 0LL);
		    HG::Rendering::HGRPLogger::LogError(v35, 0LL);
		  }
		}
		
	
		// Methods
		public void Reset() {} // 0x0000000189B668C4-0x0000000189B669EC
		// Void Reset()
		void HG::Rendering::Runtime::AtlasBuddy4::Reset(AtlasBuddy4 *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  LinkedList_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ *v4; // rcx
		  AtlasBuddy4_FreeArea__Array *m_freeArea; // rax
		  int v6; // eax
		  int v7; // ebp
		  LinkedList_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ **v8; // rax
		  LinkedList_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ *v9; // r14
		  int32_t v10; // edi
		  int32_t m_resolution; // eax
		  int32_t v12; // esi
		  int i; // edi
		  AtlasBuddy4_FreeArea__Array *v14; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2714, 0LL) )
		  {
		    m_freeArea = this->fields.m_freeArea;
		    if ( m_freeArea )
		    {
		      v6 = m_freeArea->max_length.size - 1;
		      v7 = 1 << (v6 & 0x1F);
		      v8 = (LinkedList_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ **)sub_1803C0774(
		                                                                                      this->fields.m_freeArea,
		                                                                                      v6);
		      v9 = *v8;
		      if ( *v8 )
		      {
		        System::Collections::Generic::LinkedList<UnityEngine::UIElements::UIR::UIRenderDevice::DeviceToFree>::Clear(
		          *v8,
		          MethodInfo::System::Collections::Generic::LinkedList<int>::Clear);
		        v10 = 0;
		        if ( this->fields.m_resolution > 0 )
		        {
		          m_resolution = this->fields.m_resolution;
		          do
		          {
		            v12 = 0;
		            if ( m_resolution > 0 )
		            {
		              do
		              {
		                System::Collections::Generic::LinkedList<int>::AddLast(
		                  (LinkedList_1_System_Int32_ *)v9,
		                  v10 + (v12 << (this->fields.m_resOrder & 0x1F)),
		                  MethodInfo::System::Collections::Generic::LinkedList<int>::AddLast);
		                v12 += v7;
		              }
		              while ( v12 < this->fields.m_resolution );
		            }
		            m_resolution = this->fields.m_resolution;
		            v10 += v7;
		          }
		          while ( v10 < m_resolution );
		        }
		        for ( i = 0; ; ++i )
		        {
		          v14 = this->fields.m_freeArea;
		          if ( !v14 )
		            break;
		          if ( i >= v14->max_length.size - 1 )
		            return;
		          v4 = *(LinkedList_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ **)sub_1803C0774(
		                                                                                           this->fields.m_freeArea,
		                                                                                           i);
		          if ( !v4 )
		            break;
		          System::Collections::Generic::LinkedList<UnityEngine::UIElements::UIR::UIRenderDevice::DeviceToFree>::Clear(
		            v4,
		            MethodInfo::System::Collections::Generic::LinkedList<int>::Clear);
		        }
		      }
		    }
		LABEL_15:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2714, 0LL);
		  if ( !Patch )
		    goto LABEL_15;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public RectInt InsertRect(int edge) => default; // 0x0000000189B6673C-0x0000000189B66830
		// RectInt InsertRect(Int32)
		RectInt *HG::Rendering::Runtime::AtlasBuddy4::InsertRect(
		        RectInt *__return_ptr retstr,
		        AtlasBuddy4 *this,
		        int32_t edge,
		        MethodInfo *method)
		{
		  int32_t v7; // eax
		  RectInt v8; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  int32_t y; // [rsp+30h] [rbp-38h] BYREF
		  RectInt v14; // [rsp+38h] [rbp-30h] BYREF
		  int32_t x; // [rsp+70h] [rbp+8h] BYREF
		
		  x = 0;
		  y = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(2715, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2715, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    v8 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_872(&v14, Patch, (Object *)this, edge, 0LL);
		    goto LABEL_10;
		  }
		  v14 = 0LL;
		  if ( edge == 1 )
		  {
		    HG::Rendering::HGRPLogger::LogError((String *)"Do not support square with edge 1", 0LL);
		    goto LABEL_4;
		  }
		  v7 = HG::Rendering::Runtime::AtlasBuddy4::_OrderOfEdge(edge, 0LL);
		  if ( HG::Rendering::Runtime::AtlasBuddy4::_Allocate(this, &x, &y, v7 - 1, 0LL) )
		  {
		    v14.m_Width = edge;
		    v14.m_XMin = 2 * x;
		    v14.m_Height = edge;
		    v14.m_YMin = 2 * y;
		    v8 = v14;
		LABEL_10:
		    *retstr = v8;
		    return retstr;
		  }
		LABEL_4:
		  *retstr = 0LL;
		  return retstr;
		}
		
		public void RemoveRect([IsReadOnly] in RectInt rect) {} // 0x0000000189B66830-0x0000000189B668C4
		// Void RemoveRect(RectInt ByRef)
		void HG::Rendering::Runtime::AtlasBuddy4::RemoveRect(AtlasBuddy4 *this, RectInt *rect, MethodInfo *method)
		{
		  __int64 v5; // rbx
		  int v6; // edi
		  int32_t v7; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2720, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2720, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_656(Patch, (Object *)this, rect, 0LL);
		  }
		  else
		  {
		    v5 = *(_QWORD *)&rect->m_XMin;
		    v6 = this->fields.m_resolution * HIDWORD(*(_QWORD *)&rect->m_XMin);
		    v7 = HG::Rendering::Runtime::AtlasBuddy4::_OrderOfEdge(rect->m_Width, 0LL);
		    HG::Rendering::Runtime::AtlasBuddy4::_Free(this, (v6 + (int)v5) >> 1, v7 - 1, 0LL);
		  }
		}
		
		private static bool _IsValidEdge(int edge) => default; // 0x0000000189B670E0-0x0000000189B6713C
		// Boolean _IsValidEdge(Int32)
		bool HG::Rendering::Runtime::AtlasBuddy4::_IsValidEdge(int32_t edge, MethodInfo *method)
		{
		  bool result; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  result = IFix::WrappersManagerImpl::IsPatched(2724, 0LL);
		  if ( result )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2724, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_95(
		             (ILFixDynamicMethodWrapper_17 *)Patch,
		             (AudioLogChannel__Enum)edge,
		             0LL);
		  }
		  else if ( edge > 0 )
		  {
		    return ((edge - 1) & edge) == 0;
		  }
		  return result;
		}
		
		private static int _OrderOfEdge(int edge) => default; // 0x0000000189B6713C-0x0000000189B671BC
		// Int32 _OrderOfEdge(Int32)
		int32_t HG::Rendering::Runtime::AtlasBuddy4::_OrderOfEdge(int32_t edge, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  ReadOnlySpan_1_Byte_ v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2716, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2716, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_64((ILFixDynamicMethodWrapper_18 *)Patch, edge, 0LL);
		  }
		  else
		  {
		    v7 = *HG::Rendering::Runtime::AtlasBuddy4::get_Log2DeBruijn(&v7, 0LL);
		    return *(unsigned __int8 *)(sub_180362F34(
		                                  &v7,
		                                  MethodInfo::System::Runtime::InteropServices::MemoryMarshal::GetReference<unsigned char>)
		                              + ((unsigned __int64)(unsigned int)(130329821 * (edge - 1)) >> 27))
		         + 1;
		  }
		}
		
		private int _GetStatusIndex(int pageId, int order) => default; // 0x0000000189B6700C-0x0000000189B670E0
		// Int32 _GetStatusIndex(Int32, Int32)
		int32_t HG::Rendering::Runtime::AtlasBuddy4::_GetStatusIndex(
		        AtlasBuddy4 *this,
		        int32_t pageId,
		        int32_t order,
		        MethodInfo *method)
		{
		  __int64 v5; // rbp
		  __int64 v7; // rdx
		  int32_t m_resOrder; // r12d
		  AtlasBuddy4_FreeArea__Array *m_freeArea; // rcx
		  int v10; // edi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v5 = order;
		  if ( !IFix::WrappersManagerImpl::IsPatched(2718, 0LL) )
		  {
		    m_resOrder = this->fields.m_resOrder;
		    m_freeArea = this->fields.m_freeArea;
		    if ( m_freeArea )
		    {
		      v10 = this->fields.m_resolution - 1;
		      return ((pageId & v10) >> ((v5 + 1) & 0x1F))
		           + (pageId >> (m_resOrder & 0x1F) >> ((v5 + 1) & 0x1F) << ((m_resOrder - (v5 + 1)) & 0x1F))
		           + *(_DWORD *)(sub_1803C0774(m_freeArea, v5) + 8);
		    }
		LABEL_5:
		    sub_1800D8260(m_freeArea, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2718, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_10(
		           (ILFixDynamicMethodWrapper_14 *)Patch,
		           (Object *)this,
		           (SocketOptionLevel__Enum)pageId,
		           (SocketOptionName__Enum)v5,
		           0LL);
		}
		
		private int _GetParentPageId(int pageId, int order) => default; // 0x0000000189B66F7C-0x0000000189B6700C
		// Int32 _GetParentPageId(Int32, Int32)
		int32_t HG::Rendering::Runtime::AtlasBuddy4::_GetParentPageId(
		        AtlasBuddy4 *this,
		        int32_t pageId,
		        int32_t order,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2723, 0LL) )
		    return (((pageId & (this->fields.m_resolution - 1)) >> ((order + 1) & 0x1F))
		          + this->fields.m_resolution * (pageId >> (this->fields.m_resOrder & 0x1F) >> ((order + 1) & 0x1F))) << ((order + 1) & 0x1F);
		  Patch = IFix::WrappersManagerImpl::GetPatch(2723, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v10, v9);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_10(
		           (ILFixDynamicMethodWrapper_14 *)Patch,
		           (Object *)this,
		           (SocketOptionLevel__Enum)pageId,
		           (SocketOptionName__Enum)order,
		           0LL);
		}
		
		private void _GetBuddyPageIdInTurn(out int b1, out int b2, out int b3, int b0, int order) {
			b1 = default;
			b2 = default;
			b3 = default;
		} // 0x0000000189B66DDC-0x0000000189B66E8C
		// Void _GetBuddyPageIdInTurn(Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32, Int32)
		void HG::Rendering::Runtime::AtlasBuddy4::_GetBuddyPageIdInTurn(
		        AtlasBuddy4 *this,
		        int32_t *b1,
		        int32_t *b2,
		        int32_t *b3,
		        int32_t b0,
		        int32_t order,
		        MethodInfo *method)
		{
		  int v11; // edx
		  __int64 v12; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2719, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2719, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v12);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_993(Patch, (Object *)this, b1, b2, b3, b0, order, 0LL);
		  }
		  else
		  {
		    v11 = 1 << (order & 0x1F);
		    *b2 = b0 + this->fields.m_resolution * v11;
		    *b1 = v11 + b0;
		    *b3 = v11 + *b2;
		  }
		}
		
		private void _GetBuddyPageId(out int b1, out int b2, out int b3, int b0, int order) {
			b1 = default;
			b2 = default;
			b3 = default;
		} // 0x0000000189B66E8C-0x0000000189B66F7C
		// Void _GetBuddyPageId(Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32, Int32)
		void HG::Rendering::Runtime::AtlasBuddy4::_GetBuddyPageId(
		        AtlasBuddy4 *this,
		        int32_t *b1,
		        int32_t *b2,
		        int32_t *b3,
		        int32_t b0,
		        int32_t order,
		        MethodInfo *method)
		{
		  int32_t ParentPageId; // eax
		  int v12; // edx
		  int32_t v13; // ecx
		  __int64 v14; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2722, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2722, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v14);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_993(Patch, (Object *)this, b1, b2, b3, b0, order, 0LL);
		  }
		  else
		  {
		    ParentPageId = HG::Rendering::Runtime::AtlasBuddy4::_GetParentPageId(this, b0, order, 0LL);
		    *b1 = ParentPageId;
		    v12 = 1 << (order & 0x1F);
		    *b2 = v12 + ParentPageId;
		    v13 = ParentPageId + this->fields.m_resolution * v12;
		    *b3 = v13;
		    if ( *b1 == b0 )
		      *b1 = v13 + v12;
		    if ( *b2 == b0 )
		      *b2 = v12 + *b3;
		    if ( *b3 == b0 )
		      *b3 += v12;
		  }
		}
		
		private bool _Allocate(out int x, out int y, int order) {
			x = default;
			y = default;
			return default;
		} // 0x0000000189B669EC-0x0000000189B66C2C
		// Boolean _Allocate(Int32 ByRef, Int32 ByRef, Int32)
		bool HG::Rendering::Runtime::AtlasBuddy4::_Allocate(
		        AtlasBuddy4 *this,
		        int32_t *x,
		        int32_t *y,
		        int32_t order,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  LinkedList_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ *m_buddyStatusMap; // rcx
		  int32_t i; // ebx
		  AtlasBuddy4_FreeArea__Array *m_freeArea; // rax
		  LinkedListNode_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ *head; // rsi
		  int32_t b0; // esi
		  AtlasBuddy4_FreeArea__Array *v15; // rax
		  int32_t StatusIndex; // eax
		  int32_t v17; // eax
		  bool result; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  int32_t b1; // [rsp+40h] [rbp-28h] BYREF
		  int32_t b2; // [rsp+44h] [rbp-24h] BYREF
		  int32_t b3; // [rsp+48h] [rbp-20h] BYREF
		
		  b1 = 0;
		  b2 = 0;
		  b3 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(2717, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2717, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_994(Patch, (Object *)this, x, y, order, 0LL);
		LABEL_28:
		    sub_1800D8260(m_buddyStatusMap, v9);
		  }
		  for ( i = order; ; ++i )
		  {
		    m_freeArea = this->fields.m_freeArea;
		    if ( !m_freeArea )
		      goto LABEL_28;
		    if ( i >= m_freeArea->max_length.size )
		    {
		      result = 0;
		      *x = -1;
		      *y = -1;
		      return result;
		    }
		    m_buddyStatusMap = *(LinkedList_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ **)sub_1803C0774(
		                                                                                                   this->fields.m_freeArea,
		                                                                                                   i);
		    if ( !m_buddyStatusMap )
		      goto LABEL_28;
		    if ( m_buddyStatusMap->fields.count > 0 )
		      break;
		  }
		  head = m_buddyStatusMap->fields.head;
		  if ( !head )
		    goto LABEL_28;
		  b0 = head->fields.item.handle;
		  System::Collections::Generic::LinkedList<UnityEngine::UIElements::UIR::UIRenderDevice::DeviceToFree>::RemoveFirst(
		    m_buddyStatusMap,
		    MethodInfo::System::Collections::Generic::LinkedList<int>::RemoveFirst);
		  v15 = this->fields.m_freeArea;
		  if ( !v15 )
		    goto LABEL_28;
		  if ( i == v15->max_length.size - 1 )
		    goto LABEL_23;
		  StatusIndex = HG::Rendering::Runtime::AtlasBuddy4::_GetStatusIndex(this, b0, i, 0LL);
		  m_buddyStatusMap = (LinkedList_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ *)this->fields.m_buddyStatusMap;
		  if ( !m_buddyStatusMap )
		    goto LABEL_28;
		  if ( (unsigned int)StatusIndex >= m_buddyStatusMap->fields.count )
		LABEL_25:
		    sub_1800D2AB0(m_buddyStatusMap, v9);
		  ++*((_BYTE *)&m_buddyStatusMap->fields._syncRoot + StatusIndex);
		LABEL_23:
		  while ( i > order )
		  {
		    HG::Rendering::Runtime::AtlasBuddy4::_GetBuddyPageIdInTurn(this, &b1, &b2, &b3, b0, --i, 0LL);
		    m_buddyStatusMap = (LinkedList_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ *)this->fields.m_freeArea;
		    if ( !m_buddyStatusMap )
		      goto LABEL_28;
		    m_buddyStatusMap = *(LinkedList_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ **)sub_1803C0774(
		                                                                                                   m_buddyStatusMap,
		                                                                                                   i);
		    if ( !m_buddyStatusMap )
		      goto LABEL_28;
		    System::Collections::Generic::LinkedList<int>::AddLast(
		      (LinkedList_1_System_Int32_ *)m_buddyStatusMap,
		      b1,
		      MethodInfo::System::Collections::Generic::LinkedList<int>::AddLast);
		    m_buddyStatusMap = (LinkedList_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ *)this->fields.m_freeArea;
		    if ( !m_buddyStatusMap )
		      goto LABEL_28;
		    m_buddyStatusMap = *(LinkedList_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ **)sub_1803C0774(
		                                                                                                   m_buddyStatusMap,
		                                                                                                   i);
		    if ( !m_buddyStatusMap )
		      goto LABEL_28;
		    System::Collections::Generic::LinkedList<int>::AddLast(
		      (LinkedList_1_System_Int32_ *)m_buddyStatusMap,
		      b2,
		      MethodInfo::System::Collections::Generic::LinkedList<int>::AddLast);
		    m_buddyStatusMap = (LinkedList_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ *)this->fields.m_freeArea;
		    if ( !m_buddyStatusMap )
		      goto LABEL_28;
		    m_buddyStatusMap = *(LinkedList_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ **)sub_1803C0774(
		                                                                                                   m_buddyStatusMap,
		                                                                                                   i);
		    if ( !m_buddyStatusMap )
		      goto LABEL_28;
		    System::Collections::Generic::LinkedList<int>::AddLast(
		      (LinkedList_1_System_Int32_ *)m_buddyStatusMap,
		      b3,
		      MethodInfo::System::Collections::Generic::LinkedList<int>::AddLast);
		    v17 = HG::Rendering::Runtime::AtlasBuddy4::_GetStatusIndex(this, b0, i, 0LL);
		    m_buddyStatusMap = (LinkedList_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ *)this->fields.m_buddyStatusMap;
		    if ( !m_buddyStatusMap )
		      goto LABEL_28;
		    if ( (unsigned int)v17 >= m_buddyStatusMap->fields.count )
		      goto LABEL_25;
		    *((_BYTE *)&m_buddyStatusMap->fields._syncRoot + v17) = 1;
		  }
		  result = 1;
		  *x = b0 & (this->fields.m_resolution - 1);
		  *y = b0 >> (this->fields.m_resOrder & 0x1F);
		  return result;
		}
		
		private void _Free(int pageId, int order) {} // 0x0000000189B66C2C-0x0000000189B66DDC
		// Void _Free(Int32, Int32)
		void HG::Rendering::Runtime::AtlasBuddy4::_Free(AtlasBuddy4 *this, int32_t pageId, int32_t order, MethodInfo *method)
		{
		  Byte__Array *m_buddyStatusMap; // rdx
		  LinkedList_1_System_Int32_ *v8; // rcx
		  AtlasBuddy4_FreeArea__Array *m_freeArea; // rax
		  LinkedList_1_System_Int32_ *v10; // rbp
		  int32_t StatusIndex; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  int32_t b1; // [rsp+40h] [rbp-18h] BYREF
		  int32_t b2; // [rsp+44h] [rbp-14h] BYREF
		  int32_t b3[4]; // [rsp+48h] [rbp-10h] BYREF
		
		  b1 = 0;
		  b2 = 0;
		  b3[0] = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(2721, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2721, 0LL);
		    if ( !Patch )
		      goto LABEL_19;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_272(
		      (ILFixDynamicMethodWrapper_6 *)Patch,
		      (Object *)this,
		      (UIInertiaViewPager_State__Enum)pageId,
		      (UIInertiaViewPager_State__Enum)order,
		      0LL);
		  }
		  else
		  {
		    while ( 1 )
		    {
		      m_freeArea = this->fields.m_freeArea;
		      if ( !m_freeArea )
		        goto LABEL_19;
		      v8 = (LinkedList_1_System_Int32_ *)this->fields.m_freeArea;
		      if ( order >= m_freeArea->max_length.size - 1 )
		        break;
		      v10 = *(LinkedList_1_System_Int32_ **)sub_1803C0774(v8, order);
		      StatusIndex = HG::Rendering::Runtime::AtlasBuddy4::_GetStatusIndex(this, pageId, order, 0LL);
		      m_buddyStatusMap = this->fields.m_buddyStatusMap;
		      if ( !m_buddyStatusMap )
		        goto LABEL_19;
		      if ( (unsigned int)StatusIndex >= m_buddyStatusMap->max_length.size )
		        goto LABEL_14;
		      --m_buddyStatusMap->vector[StatusIndex];
		      v8 = (LinkedList_1_System_Int32_ *)this->fields.m_buddyStatusMap;
		      if ( !v8 )
		        goto LABEL_19;
		      if ( (unsigned int)StatusIndex >= v8->fields.count )
		LABEL_14:
		        sub_1800D2AB0(v8, m_buddyStatusMap);
		      if ( *((_BYTE *)&v8->fields._syncRoot + StatusIndex) )
		      {
		        if ( v10 )
		        {
		          v8 = v10;
		          goto LABEL_13;
		        }
		LABEL_19:
		        sub_1800D8260(v8, m_buddyStatusMap);
		      }
		      HG::Rendering::Runtime::AtlasBuddy4::_GetBuddyPageId(this, &b1, &b2, b3, pageId, order, 0LL);
		      if ( !v10 )
		        goto LABEL_19;
		      System::Collections::Generic::LinkedList<int>::Remove(
		        v10,
		        b1,
		        MethodInfo::System::Collections::Generic::LinkedList<int>::Remove);
		      System::Collections::Generic::LinkedList<int>::Remove(
		        v10,
		        b2,
		        MethodInfo::System::Collections::Generic::LinkedList<int>::Remove);
		      System::Collections::Generic::LinkedList<int>::Remove(
		        v10,
		        b3[0],
		        MethodInfo::System::Collections::Generic::LinkedList<int>::Remove);
		      pageId = HG::Rendering::Runtime::AtlasBuddy4::_GetParentPageId(this, pageId, order++, 0LL);
		    }
		    if ( !v8 )
		      goto LABEL_19;
		    v8 = *(LinkedList_1_System_Int32_ **)sub_1803C0774(v8, v8->fields.count - 1LL);
		    if ( !v8 )
		      goto LABEL_19;
		LABEL_13:
		    System::Collections::Generic::LinkedList<int>::AddLast(
		      v8,
		      pageId,
		      MethodInfo::System::Collections::Generic::LinkedList<int>::AddLast);
		  }
		}
		
	}
}
