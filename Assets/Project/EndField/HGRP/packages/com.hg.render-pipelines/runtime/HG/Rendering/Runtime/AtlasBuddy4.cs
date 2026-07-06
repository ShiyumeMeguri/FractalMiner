using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public class AtlasBuddy4
	{
		// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x000025D2 File Offset: 0x000007D2
		private static ReadOnlySpan<byte> Log2DeBruijn
		{
			get
			{
				// // ReadOnlySpan`1[Byte] get_Log2DeBruijn()
				// ReadOnlySpan_1_Byte_ *HG::Rendering::Runtime::AtlasBuddy4::get_Log2DeBruijn(
				//         ReadOnlySpan_1_Byte_ *__return_ptr retstr,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				//   ReadOnlySpan_1_Byte_ v7; // [rsp+20h] [rbp-18h] BYREF
				// 
				//   if ( !byte_18D919465 )
				//   {
				//     sub_18003C530(&MethodInfo::System::ReadOnlySpan<unsigned char>::ReadOnlySpan);
				//     sub_18003C530(&4BCD43D478B9229AB7A13406353712C7944B60348C36B4D0E6B789D10F697652_FieldRva);
				//     byte_18D919465 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(2252, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2252, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v5, v4);
				//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_813(&v7, Patch, 0LL);
				//   }
				//   else
				//   {
				//     *retstr = 0LL;
				//     sub_182B467E0(
				//       retstr,
				//       4BCD43D478B9229AB7A13406353712C7944B60348C36B4D0E6B789D10F697652_FieldRva,
				//       32LL,
				//       MethodInfo::System::ReadOnlySpan<unsigned char>::ReadOnlySpan);
				//   }
				//   return retstr;
				// }
				// 
				return null;
			}
		}

		public AtlasBuddy4(int atlasResolution, int maxImageResolution)
		{
			// // AtlasBuddy4(Int32, Int32)
			// void HG::Rendering::Runtime::AtlasBuddy4::AtlasBuddy4(
			//         AtlasBuddy4 *this,
			//         int32_t atlasResolution,
			//         int32_t maxImageResolution,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // r8
			//   int32_t v8; // edi
			//   int32_t v9; // eax
			//   int v10; // r13d
			//   int32_t v11; // r14d
			//   __int64 v12; // r8
			//   __int64 v13; // r9
			//   OneofDescriptorProto *v14; // rdx
			//   FileDescriptor *v15; // r8
			//   MessageDescriptor *v16; // r9
			//   __int64 v17; // rdx
			//   AtlasBuddy4_FreeArea__Array *v18; // rcx
			//   __int64 v19; // r8
			//   __int64 v20; // r9
			//   unsigned int v21; // esi
			//   int32_t v22; // edi
			//   int i; // r12d
			//   AtlasBuddy4_FreeArea__Array *m_freeArea; // rax
			//   AtlasBuddy4_FreeArea__Array *v25; // r15
			//   __int64 v26; // rbp
			//   OneofDescriptor *v27; // rax
			//   OneofDescriptorProto *v28; // rdx
			//   FileDescriptor *v29; // r8
			//   MessageDescriptor *v30; // r9
			//   __int64 v31; // rax
			//   OneofDescriptorProto *v32; // rdx
			//   FileDescriptor *v33; // r8
			//   MessageDescriptor *v34; // r9
			//   int32_t v35; // edi
			//   LinkedList_1_System_Int32_ *v36; // rbp
			//   int32_t v37; // esi
			//   Object *v38; // rbx
			//   __int64 v39; // r8
			//   Object *v40; // rax
			//   String *v41; // rax
			//   String__Array *v42; // [rsp+20h] [rbp-38h]
			//   String__Array *v43; // [rsp+20h] [rbp-38h]
			//   int v44; // [rsp+20h] [rbp-38h]
			//   String *v45; // [rsp+28h] [rbp-30h]
			//   String *v46; // [rsp+28h] [rbp-30h]
			//   MethodInfo *v47; // [rsp+30h] [rbp-28h]
			//   MethodInfo *v48; // [rsp+30h] [rbp-28h]
			//   int32_t v49; // [rsp+68h] [rbp+10h] BYREF
			// 
			//   if ( !byte_18D919466 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Byte);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::AtlasBuddy4::FreeArea);
			//     sub_18003C530(&TypeInfo::System::Int32);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::LinkedList<int>::AddLast);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::LinkedList<int>::LinkedList);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::LinkedList<int>);
			//     sub_18003C530(&off_18D4EB680);
			//     byte_18D919466 = 1;
			//   }
			//   if ( HG::Rendering::Runtime::AtlasBuddy4::_IsValidEdge(atlasResolution, 0LL)
			//     && HG::Rendering::Runtime::AtlasBuddy4::_IsValidEdge(maxImageResolution, 0LL)
			//     && atlasResolution >= maxImageResolution )
			//   {
			//     v8 = atlasResolution >> 1;
			//     this.fields.m_resolution = v8;
			//     if ( v8 == 1 )
			//       v9 = 0;
			//     else
			//       v9 = HG::Rendering::Runtime::AtlasBuddy4::_OrderOfEdge(v8, 0LL);
			//     this.fields.m_resOrder = v9;
			//     v10 = this.fields.m_resolution * this.fields.m_resolution;
			//     v11 = maxImageResolution >> 1;
			//     v42 = (String__Array *)(unsigned int)HG::Rendering::Runtime::AtlasBuddy4::_OrderOfEdge(maxImageResolution, 0LL);
			//     this.fields.m_freeArea = (AtlasBuddy4_FreeArea__Array *)il2cpp_array_new_specific_0(
			//                                                                TypeInfo::HG::Rendering::Runtime::AtlasBuddy4::FreeArea,
			//                                                                v42,
			//                                                                v12,
			//                                                                v13);
			//     sub_1800054D0((OneofDescriptor *)&this.fields.m_freeArea, v14, v15, v16, v42, v45, v47);
			//     v21 = 0;
			//     v22 = 0;
			//     for ( i = 2; ; i += 2 )
			//     {
			//       m_freeArea = this.fields.m_freeArea;
			//       if ( !m_freeArea )
			//         goto LABEL_22;
			//       if ( v22 >= m_freeArea.max_length.size )
			//         break;
			//       v25 = this.fields.m_freeArea;
			//       v26 = sub_180004920(TypeInfo::System::Collections::Generic::LinkedList<int>);
			//       if ( !v26 )
			//         goto LABEL_22;
			//       *(_QWORD *)sub_18037A2E0(v25, v22) = v26;
			//       v27 = (OneofDescriptor *)sub_18037A2E0(v25, v22);
			//       sub_1800054D0(v27, v28, v29, v30, v43, v46, v48);
			//       v18 = this.fields.m_freeArea;
			//       if ( !v18 )
			//         goto LABEL_22;
			//       v31 = sub_18037A2E0(v18, v22++);
			//       v18 = (AtlasBuddy4_FreeArea__Array *)(i & 0x1F);
			//       *(_DWORD *)(v31 + 8) = v21;
			//       v21 += v10 >> (char)v18;
			//     }
			//     this.fields.m_buddyStatusMap = (Byte__Array *)il2cpp_array_new_specific_0(TypeInfo::System::Byte, v21, v19, v20);
			//     sub_1800054D0((OneofDescriptor *)&this.fields.m_buddyStatusMap, v32, v33, v34, v43, v46, v48);
			//     v18 = this.fields.m_freeArea;
			//     if ( !v18 )
			// LABEL_22:
			//       sub_180B536AC(v18, v17);
			//     v35 = 0;
			//     v36 = *(LinkedList_1_System_Int32_ **)sub_18037A2E0(v18, v44 - 1LL);
			//     if ( this.fields.m_resolution > 0 )
			//     {
			//       while ( 1 )
			//       {
			//         v37 = 0;
			//         if ( this.fields.m_resolution > 0 )
			//           break;
			// LABEL_20:
			//         v35 += v11;
			//         if ( v35 >= this.fields.m_resolution )
			//           return;
			//       }
			//       while ( v36 )
			//       {
			//         System::Collections::Generic::LinkedList<int>::AddLast(
			//           v36,
			//           v35 + (v37 << (this.fields.m_resOrder & 0x1F)),
			//           MethodInfo::System::Collections::Generic::LinkedList<int>::AddLast);
			//         v37 += v11;
			//         if ( v37 >= this.fields.m_resolution )
			//           goto LABEL_20;
			//       }
			//       goto LABEL_22;
			//     }
			//   }
			//   else
			//   {
			//     v49 = atlasResolution;
			//     v38 = (Object *)il2cpp_value_box_0(TypeInfo::System::Int32, &v49, v7);
			//     v49 = maxImageResolution;
			//     v40 = (Object *)il2cpp_value_box_0(TypeInfo::System::Int32, &v49, v39);
			//     v41 = System::String::Format((String *)"Unsupported Atlas size: {0} or max image size: {1}.", v38, v40, 0LL);
			//     HG::Rendering::HGRPLogger::LogError(v41, 0LL);
			//   }
			// }
			// 
		}

		public void Reset()
		{
			// // Void Reset()
			// void HG::Rendering::Runtime::AtlasBuddy4::Reset(AtlasBuddy4 *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   LinkedList_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ *v4; // rcx
			//   AtlasBuddy4_FreeArea__Array *m_freeArea; // rax
			//   int v6; // eax
			//   int v7; // ebp
			//   LinkedList_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ **v8; // rax
			//   LinkedList_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ *v9; // r14
			//   int32_t v10; // edi
			//   int32_t m_resolution; // eax
			//   int32_t v12; // esi
			//   int i; // edi
			//   AtlasBuddy4_FreeArea__Array *v14; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919467 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::LinkedList<int>::AddLast);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::LinkedList<int>::Clear);
			//     byte_18D919467 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2253, 0LL) )
			//   {
			//     m_freeArea = this.fields.m_freeArea;
			//     if ( m_freeArea )
			//     {
			//       v6 = m_freeArea.max_length.size - 1;
			//       v7 = 1 << (v6 & 0x1F);
			//       v8 = (LinkedList_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ **)sub_18037A2E0(
			//                                                                                       this.fields.m_freeArea,
			//                                                                                       v6);
			//       v9 = *v8;
			//       if ( *v8 )
			//       {
			//         System::Collections::Generic::LinkedList<UnityEngine::UIElements::UIR::UIRenderDevice::DeviceToFree>::Clear(
			//           *v8,
			//           MethodInfo::System::Collections::Generic::LinkedList<int>::Clear);
			//         v10 = 0;
			//         if ( this.fields.m_resolution > 0 )
			//         {
			//           m_resolution = this.fields.m_resolution;
			//           do
			//           {
			//             v12 = 0;
			//             if ( m_resolution > 0 )
			//             {
			//               do
			//               {
			//                 System::Collections::Generic::LinkedList<int>::AddLast(
			//                   (LinkedList_1_System_Int32_ *)v9,
			//                   v10 + (v12 << (this.fields.m_resOrder & 0x1F)),
			//                   MethodInfo::System::Collections::Generic::LinkedList<int>::AddLast);
			//                 v12 += v7;
			//               }
			//               while ( v12 < this.fields.m_resolution );
			//             }
			//             m_resolution = this.fields.m_resolution;
			//             v10 += v7;
			//           }
			//           while ( v10 < m_resolution );
			//         }
			//         for ( i = 0; ; ++i )
			//         {
			//           v14 = this.fields.m_freeArea;
			//           if ( !v14 )
			//             break;
			//           if ( i >= v14.max_length.size - 1 )
			//             return;
			//           v4 = *(LinkedList_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ **)sub_18037A2E0(
			//                                                                                            this.fields.m_freeArea,
			//                                                                                            i);
			//           if ( !v4 )
			//             break;
			//           System::Collections::Generic::LinkedList<UnityEngine::UIElements::UIR::UIRenderDevice::DeviceToFree>::Clear(
			//             v4,
			//             MethodInfo::System::Collections::Generic::LinkedList<int>::Clear);
			//         }
			//       }
			//     }
			// LABEL_17:
			//     sub_180B536AC(v4, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2253, 0LL);
			//   if ( !Patch )
			//     goto LABEL_17;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public RectInt InsertRect(int edge)
		{
			// // RectInt InsertRect(Int32)
			// RectInt *HG::Rendering::Runtime::AtlasBuddy4::InsertRect(
			//         RectInt *__return_ptr retstr,
			//         AtlasBuddy4 *this,
			//         int32_t edge,
			//         MethodInfo *method)
			// {
			//   int32_t v7; // eax
			//   RectInt v8; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   int32_t y; // [rsp+30h] [rbp-38h] BYREF
			//   RectInt v14; // [rsp+38h] [rbp-30h] BYREF
			//   int32_t x; // [rsp+70h] [rbp+8h] BYREF
			// 
			//   if ( !byte_18D919468 )
			//   {
			//     sub_18003C530(&off_18D4EB738);
			//     byte_18D919468 = 1;
			//   }
			//   x = 0;
			//   y = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2254, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2254, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     v8 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_711(&v14, Patch, (Object *)this, edge, 0LL);
			//     goto LABEL_12;
			//   }
			//   v14 = 0LL;
			//   if ( edge == 1 )
			//   {
			//     HG::Rendering::HGRPLogger::LogError((String *)"Do not support square with edge 1", 0LL);
			//     goto LABEL_6;
			//   }
			//   v7 = HG::Rendering::Runtime::AtlasBuddy4::_OrderOfEdge(edge, 0LL);
			//   if ( HG::Rendering::Runtime::AtlasBuddy4::_Allocate(this, &x, &y, v7 - 1, 0LL) )
			//   {
			//     v14.m_Width = edge;
			//     v14.m_XMin = 2 * x;
			//     v14.m_Height = edge;
			//     v14.m_YMin = 2 * y;
			//     v8 = v14;
			// LABEL_12:
			//     *retstr = v8;
			//     return retstr;
			//   }
			// LABEL_6:
			//   *retstr = 0LL;
			//   return retstr;
			// }
			// 
			return null;
		}

		public void RemoveRect(in RectInt rect)
		{
			// // Void RemoveRect(RectInt ByRef)
			// void HG::Rendering::Runtime::AtlasBuddy4::RemoveRect(AtlasBuddy4 *this, RectInt *rect, MethodInfo *method)
			// {
			//   __int64 v5; // rbx
			//   int v6; // edi
			//   int32_t v7; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2259, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2259, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_514(Patch, (Object *)this, rect, 0LL);
			//   }
			//   else
			//   {
			//     v5 = *(_QWORD *)&rect.m_XMin;
			//     v6 = this.fields.m_resolution * HIDWORD(*(_QWORD *)&rect.m_XMin);
			//     v7 = HG::Rendering::Runtime::AtlasBuddy4::_OrderOfEdge(rect.m_Width, 0LL);
			//     HG::Rendering::Runtime::AtlasBuddy4::_Free(this, (v6 + (int)v5) >> 1, v7 - 1, 0LL);
			//   }
			// }
			// 
		}

		private static bool _IsValidEdge(int edge)
		{
			// // Boolean _IsValidEdge(Int32)
			// bool HG::Rendering::Runtime::AtlasBuddy4::_IsValidEdge(int32_t edge, MethodInfo *method)
			// {
			//   bool result; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   result = IFix::WrappersManagerImpl::IsPatched(2263, 0LL);
			//   if ( result )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2263, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_86(
			//              (ILFixDynamicMethodWrapper_17 *)Patch,
			//              (AudioLogChannel__Enum)edge,
			//              0LL);
			//   }
			//   else if ( edge > 0 )
			//   {
			//     return ((edge - 1) & edge) == 0;
			//   }
			//   return result;
			// }
			// 
			return default(bool);
		}

		private static int _OrderOfEdge(int edge)
		{
			// // Int32 _OrderOfEdge(Int32)
			// int32_t HG::Rendering::Runtime::AtlasBuddy4::_OrderOfEdge(int32_t edge, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   ReadOnlySpan_1_Byte_ v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919469 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Runtime::InteropServices::MemoryMarshal::GetReference<unsigned char>);
			//     byte_18D919469 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2255, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2255, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_71((ILFixDynamicMethodWrapper_17 *)Patch, edge, 0LL);
			//   }
			//   else
			//   {
			//     v7 = *HG::Rendering::Runtime::AtlasBuddy4::get_Log2DeBruijn(&v7, 0LL);
			//     return *(unsigned __int8 *)(sub_180314094(
			//                                   &v7,
			//                                   MethodInfo::System::Runtime::InteropServices::MemoryMarshal::GetReference<unsigned char>)
			//                               + ((unsigned __int64)(unsigned int)(130329821 * (edge - 1)) >> 27))
			//          + 1;
			//   }
			// }
			// 
			return 0;
		}

		private int _GetStatusIndex(int pageId, int order)
		{
			// // Int32 _GetStatusIndex(Int32, Int32)
			// int32_t HG::Rendering::Runtime::AtlasBuddy4::_GetStatusIndex(
			//         AtlasBuddy4 *this,
			//         int32_t pageId,
			//         int32_t order,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rbp
			//   __int64 v7; // rdx
			//   int32_t m_resOrder; // r12d
			//   AtlasBuddy4_FreeArea__Array *m_freeArea; // rcx
			//   int v10; // edi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   v5 = order;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2257, 0LL) )
			//   {
			//     m_resOrder = this.fields.m_resOrder;
			//     m_freeArea = this.fields.m_freeArea;
			//     if ( m_freeArea )
			//     {
			//       v10 = this.fields.m_resolution - 1;
			//       return ((pageId & v10) >> ((v5 + 1) & 0x1F))
			//            + (pageId >> (m_resOrder & 0x1F) >> ((v5 + 1) & 0x1F) << ((m_resOrder - (v5 + 1)) & 0x1F))
			//            + *(_DWORD *)(sub_18037A2E0(m_freeArea, v5) + 8);
			//     }
			// LABEL_5:
			//     sub_180B536AC(m_freeArea, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2257, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8(
			//            (ILFixDynamicMethodWrapper_14 *)Patch,
			//            (Object *)this,
			//            (SocketOptionLevel__Enum)pageId,
			//            (SocketOptionName__Enum)v5,
			//            0LL);
			// }
			// 
			return 0;
		}

		private int _GetParentPageId(int pageId, int order)
		{
			// // Int32 _GetParentPageId(Int32, Int32)
			// int32_t HG::Rendering::Runtime::AtlasBuddy4::_GetParentPageId(
			//         AtlasBuddy4 *this,
			//         int32_t pageId,
			//         int32_t order,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2262, 0LL) )
			//     return (((pageId & (this.fields.m_resolution - 1)) >> ((order + 1) & 0x1F))
			//           + this.fields.m_resolution * (pageId >> (this.fields.m_resOrder & 0x1F) >> ((order + 1) & 0x1F))) << ((order + 1) & 0x1F);
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2262, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v10, v9);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8(
			//            (ILFixDynamicMethodWrapper_14 *)Patch,
			//            (Object *)this,
			//            (SocketOptionLevel__Enum)pageId,
			//            (SocketOptionName__Enum)order,
			//            0LL);
			// }
			// 
			return 0;
		}

		private void _GetBuddyPageIdInTurn(out int b1, out int b2, out int b3, int b0, int order)
		{
			// // Void _GetBuddyPageIdInTurn(Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32, Int32)
			// void HG::Rendering::Runtime::AtlasBuddy4::_GetBuddyPageIdInTurn(
			//         AtlasBuddy4 *this,
			//         int32_t *b1,
			//         int32_t *b2,
			//         int32_t *b3,
			//         int32_t b0,
			//         int32_t order,
			//         MethodInfo *method)
			// {
			//   int v11; // edx
			//   __int64 v12; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2258, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2258, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v12);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_814(Patch, (Object *)this, b1, b2, b3, b0, order, 0LL);
			//   }
			//   else
			//   {
			//     v11 = 1 << (order & 0x1F);
			//     *b2 = b0 + this.fields.m_resolution * v11;
			//     *b1 = v11 + b0;
			//     *b3 = v11 + *b2;
			//   }
			// }
			// 
		}

		private void _GetBuddyPageId(out int b1, out int b2, out int b3, int b0, int order)
		{
			// // Void _GetBuddyPageId(Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32, Int32)
			// void HG::Rendering::Runtime::AtlasBuddy4::_GetBuddyPageId(
			//         AtlasBuddy4 *this,
			//         int32_t *b1,
			//         int32_t *b2,
			//         int32_t *b3,
			//         int32_t b0,
			//         int32_t order,
			//         MethodInfo *method)
			// {
			//   int32_t ParentPageId; // eax
			//   int v12; // edx
			//   int32_t v13; // ecx
			//   __int64 v14; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2261, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2261, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v14);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_814(Patch, (Object *)this, b1, b2, b3, b0, order, 0LL);
			//   }
			//   else
			//   {
			//     ParentPageId = HG::Rendering::Runtime::AtlasBuddy4::_GetParentPageId(this, b0, order, 0LL);
			//     *b1 = ParentPageId;
			//     v12 = 1 << (order & 0x1F);
			//     *b2 = v12 + ParentPageId;
			//     v13 = ParentPageId + this.fields.m_resolution * v12;
			//     *b3 = v13;
			//     if ( *b1 == b0 )
			//       *b1 = v13 + v12;
			//     if ( *b2 == b0 )
			//       *b2 = v12 + *b3;
			//     if ( *b3 == b0 )
			//       *b3 += v12;
			//   }
			// }
			// 
		}

		private bool _Allocate(out int x, out int y, int order)
		{
			// // Boolean _Allocate(Int32 ByRef, Int32 ByRef, Int32)
			// bool HG::Rendering::Runtime::AtlasBuddy4::_Allocate(
			//         AtlasBuddy4 *this,
			//         int32_t *x,
			//         int32_t *y,
			//         int32_t order,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   LinkedList_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ *m_buddyStatusMap; // rcx
			//   int32_t i; // ebx
			//   AtlasBuddy4_FreeArea__Array *m_freeArea; // rax
			//   LinkedListNode_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ *head; // rsi
			//   int32_t b0; // esi
			//   AtlasBuddy4_FreeArea__Array *v15; // rax
			//   int32_t StatusIndex; // eax
			//   int32_t v17; // eax
			//   bool result; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   int32_t b1; // [rsp+40h] [rbp-28h] BYREF
			//   int32_t b2; // [rsp+44h] [rbp-24h] BYREF
			//   int32_t b3; // [rsp+48h] [rbp-20h] BYREF
			// 
			//   if ( !byte_18D91946A )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::LinkedListNode<int>::get_Value);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::LinkedList<int>::AddLast);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::LinkedList<int>::RemoveFirst);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::LinkedList<int>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::LinkedList<int>::get_First);
			//     byte_18D91946A = 1;
			//   }
			//   b1 = 0;
			//   b2 = 0;
			//   b3 = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2256, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2256, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_815(Patch, (Object *)this, x, y, order, 0LL);
			// LABEL_30:
			//     sub_180B536AC(m_buddyStatusMap, v9);
			//   }
			//   for ( i = order; ; ++i )
			//   {
			//     m_freeArea = this.fields.m_freeArea;
			//     if ( !m_freeArea )
			//       goto LABEL_30;
			//     if ( i >= m_freeArea.max_length.size )
			//     {
			//       result = 0;
			//       *x = -1;
			//       *y = -1;
			//       return result;
			//     }
			//     m_buddyStatusMap = *(LinkedList_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ **)sub_18037A2E0(
			//                                                                                                    this.fields.m_freeArea,
			//                                                                                                    i);
			//     if ( !m_buddyStatusMap )
			//       goto LABEL_30;
			//     if ( m_buddyStatusMap.fields.count > 0 )
			//       break;
			//   }
			//   head = m_buddyStatusMap.fields.head;
			//   if ( !head )
			//     goto LABEL_30;
			//   b0 = head.fields.item.handle;
			//   System::Collections::Generic::LinkedList<UnityEngine::UIElements::UIR::UIRenderDevice::DeviceToFree>::RemoveFirst(
			//     m_buddyStatusMap,
			//     MethodInfo::System::Collections::Generic::LinkedList<int>::RemoveFirst);
			//   v15 = this.fields.m_freeArea;
			//   if ( !v15 )
			//     goto LABEL_30;
			//   if ( i == v15.max_length.size - 1 )
			//     goto LABEL_25;
			//   StatusIndex = HG::Rendering::Runtime::AtlasBuddy4::_GetStatusIndex(this, b0, i, 0LL);
			//   m_buddyStatusMap = (LinkedList_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ *)this.fields.m_buddyStatusMap;
			//   if ( !m_buddyStatusMap )
			//     goto LABEL_30;
			//   if ( (unsigned int)StatusIndex >= m_buddyStatusMap.fields.count )
			// LABEL_27:
			//     sub_180070270(m_buddyStatusMap, v9);
			//   ++*((_BYTE *)&m_buddyStatusMap.fields._syncRoot + StatusIndex);
			// LABEL_25:
			//   while ( i > order )
			//   {
			//     HG::Rendering::Runtime::AtlasBuddy4::_GetBuddyPageIdInTurn(this, &b1, &b2, &b3, b0, --i, 0LL);
			//     m_buddyStatusMap = (LinkedList_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ *)this.fields.m_freeArea;
			//     if ( !m_buddyStatusMap )
			//       goto LABEL_30;
			//     m_buddyStatusMap = *(LinkedList_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ **)sub_18037A2E0(
			//                                                                                                    m_buddyStatusMap,
			//                                                                                                    i);
			//     if ( !m_buddyStatusMap )
			//       goto LABEL_30;
			//     System::Collections::Generic::LinkedList<int>::AddLast(
			//       (LinkedList_1_System_Int32_ *)m_buddyStatusMap,
			//       b1,
			//       MethodInfo::System::Collections::Generic::LinkedList<int>::AddLast);
			//     m_buddyStatusMap = (LinkedList_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ *)this.fields.m_freeArea;
			//     if ( !m_buddyStatusMap )
			//       goto LABEL_30;
			//     m_buddyStatusMap = *(LinkedList_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ **)sub_18037A2E0(
			//                                                                                                    m_buddyStatusMap,
			//                                                                                                    i);
			//     if ( !m_buddyStatusMap )
			//       goto LABEL_30;
			//     System::Collections::Generic::LinkedList<int>::AddLast(
			//       (LinkedList_1_System_Int32_ *)m_buddyStatusMap,
			//       b2,
			//       MethodInfo::System::Collections::Generic::LinkedList<int>::AddLast);
			//     m_buddyStatusMap = (LinkedList_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ *)this.fields.m_freeArea;
			//     if ( !m_buddyStatusMap )
			//       goto LABEL_30;
			//     m_buddyStatusMap = *(LinkedList_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ **)sub_18037A2E0(
			//                                                                                                    m_buddyStatusMap,
			//                                                                                                    i);
			//     if ( !m_buddyStatusMap )
			//       goto LABEL_30;
			//     System::Collections::Generic::LinkedList<int>::AddLast(
			//       (LinkedList_1_System_Int32_ *)m_buddyStatusMap,
			//       b3,
			//       MethodInfo::System::Collections::Generic::LinkedList<int>::AddLast);
			//     v17 = HG::Rendering::Runtime::AtlasBuddy4::_GetStatusIndex(this, b0, i, 0LL);
			//     m_buddyStatusMap = (LinkedList_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ *)this.fields.m_buddyStatusMap;
			//     if ( !m_buddyStatusMap )
			//       goto LABEL_30;
			//     if ( (unsigned int)v17 >= m_buddyStatusMap.fields.count )
			//       goto LABEL_27;
			//     *((_BYTE *)&m_buddyStatusMap.fields._syncRoot + v17) = 1;
			//   }
			//   result = 1;
			//   *x = b0 & (this.fields.m_resolution - 1);
			//   *y = b0 >> (this.fields.m_resOrder & 0x1F);
			//   return result;
			// }
			// 
			return default(bool);
		}

		private void _Free(int pageId, int order)
		{
			// // Void _Free(Int32, Int32)
			// void HG::Rendering::Runtime::AtlasBuddy4::_Free(AtlasBuddy4 *this, int32_t pageId, int32_t order, MethodInfo *method)
			// {
			//   Byte__Array *m_buddyStatusMap; // rdx
			//   LinkedList_1_System_Int32_ *v8; // rcx
			//   AtlasBuddy4_FreeArea__Array *m_freeArea; // rax
			//   LinkedList_1_System_Int32_ *v10; // rbp
			//   int32_t StatusIndex; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   int32_t b1; // [rsp+40h] [rbp-18h] BYREF
			//   int32_t b2; // [rsp+44h] [rbp-14h] BYREF
			//   int32_t b3[4]; // [rsp+48h] [rbp-10h] BYREF
			// 
			//   if ( !byte_18D91946B )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::LinkedList<int>::AddLast);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::LinkedList<int>::Remove);
			//     byte_18D91946B = 1;
			//   }
			//   b1 = 0;
			//   b2 = 0;
			//   b3[0] = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2260, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2260, 0LL);
			//     if ( !Patch )
			//       goto LABEL_21;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_56(
			//       (ILFixDynamicMethodWrapper_20 *)Patch,
			//       (Object *)this,
			//       pageId,
			//       order,
			//       0LL);
			//   }
			//   else
			//   {
			//     while ( 1 )
			//     {
			//       m_freeArea = this.fields.m_freeArea;
			//       if ( !m_freeArea )
			//         goto LABEL_21;
			//       v8 = (LinkedList_1_System_Int32_ *)this.fields.m_freeArea;
			//       if ( order >= m_freeArea.max_length.size - 1 )
			//         break;
			//       v10 = *(LinkedList_1_System_Int32_ **)sub_18037A2E0(v8, order);
			//       StatusIndex = HG::Rendering::Runtime::AtlasBuddy4::_GetStatusIndex(this, pageId, order, 0LL);
			//       m_buddyStatusMap = this.fields.m_buddyStatusMap;
			//       if ( !m_buddyStatusMap )
			//         goto LABEL_21;
			//       if ( (unsigned int)StatusIndex >= m_buddyStatusMap.max_length.size )
			//         goto LABEL_16;
			//       --m_buddyStatusMap.vector[StatusIndex];
			//       v8 = (LinkedList_1_System_Int32_ *)this.fields.m_buddyStatusMap;
			//       if ( !v8 )
			//         goto LABEL_21;
			//       if ( (unsigned int)StatusIndex >= v8.fields.count )
			// LABEL_16:
			//         sub_180070270(v8, m_buddyStatusMap);
			//       if ( *((_BYTE *)&v8.fields._syncRoot + StatusIndex) )
			//       {
			//         if ( v10 )
			//         {
			//           v8 = v10;
			//           goto LABEL_15;
			//         }
			// LABEL_21:
			//         sub_180B536AC(v8, m_buddyStatusMap);
			//       }
			//       HG::Rendering::Runtime::AtlasBuddy4::_GetBuddyPageId(this, &b1, &b2, b3, pageId, order, 0LL);
			//       if ( !v10 )
			//         goto LABEL_21;
			//       System::Collections::Generic::LinkedList<int>::Remove(
			//         v10,
			//         b1,
			//         MethodInfo::System::Collections::Generic::LinkedList<int>::Remove);
			//       System::Collections::Generic::LinkedList<int>::Remove(
			//         v10,
			//         b2,
			//         MethodInfo::System::Collections::Generic::LinkedList<int>::Remove);
			//       System::Collections::Generic::LinkedList<int>::Remove(
			//         v10,
			//         b3[0],
			//         MethodInfo::System::Collections::Generic::LinkedList<int>::Remove);
			//       pageId = HG::Rendering::Runtime::AtlasBuddy4::_GetParentPageId(this, pageId, order++, 0LL);
			//     }
			//     if ( !v8 )
			//       goto LABEL_21;
			//     v8 = *(LinkedList_1_System_Int32_ **)sub_18037A2E0(v8, v8.fields.count - 1LL);
			//     if ( !v8 )
			//       goto LABEL_21;
			// LABEL_15:
			//     System::Collections::Generic::LinkedList<int>::AddLast(
			//       v8,
			//       pageId,
			//       MethodInfo::System::Collections::Generic::LinkedList<int>::AddLast);
			//   }
			// }
			// 
		}

		private readonly int m_resolution;

		private readonly int m_resOrder;

		private readonly AtlasBuddy4.FreeArea[] m_freeArea;

		private readonly byte[] m_buddyStatusMap;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		private struct FreeArea
		{
			public LinkedList<int> freePageId;

			public int statusMapOffset;
		}
	}
}
