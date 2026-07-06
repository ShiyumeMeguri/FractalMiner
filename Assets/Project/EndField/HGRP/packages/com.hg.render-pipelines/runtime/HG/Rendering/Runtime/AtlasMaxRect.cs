using System;
using System.Collections.Generic;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public class AtlasMaxRect
	{
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool empty
		{
			get
			{
				// // Boolean get_empty()
				// bool HG::Rendering::Runtime::AtlasMaxRect::get_empty(AtlasMaxRect *this, MethodInfo *method)
				// {
				//   return this.fields.m_usedRectSize == 0;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x00002608 File Offset: 0x00000808
		public int maxFreeRectWidth
		{
			get
			{
				// // Int32 get_peakCount()
				// int32_t Beyond::PoolCore::ObjectPool<System::Object>::get_peakCount(
				//         ObjectPool_1_System_Object__3 *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.m_peekCount;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x00002608 File Offset: 0x00000808
		public int maxFreeRectHeight
		{
			get
			{
				// // Int32 get_countAll()
				// int32_t Beyond::PoolCore::ObjectPool<System::Object>::get_countAll(
				//         ObjectPool_1_System_Object__3 *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._countAll_k__BackingField;
				// }
				// 
				return 0;
			}
		}

		public AtlasMaxRect(int width, int height)
		{
			// // AtlasMaxRect(Int32, Int32)
			// void HG::Rendering::Runtime::AtlasMaxRect::AtlasMaxRect(
			//         AtlasMaxRect *this,
			//         int32_t width,
			//         int32_t height,
			//         MethodInfo *method)
			// {
			//   LowLevelList_1_System_Object_ *v7; // rax
			//   __int64 v8; // rdx
			//   Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *m_usedRectangles; // rcx
			//   List_1_UnityEngine_RectInt_ *v10; // rdi
			//   OneofDescriptorProto *v11; // rdx
			//   FileDescriptor *v12; // r8
			//   MessageDescriptor *v13; // r9
			//   LowLevelList_1_System_Object_ *v14; // rax
			//   List_1_UnityEngine_RectInt_ *v15; // rdi
			//   OneofDescriptorProto *v16; // rdx
			//   FileDescriptor *v17; // r8
			//   MessageDescriptor *v18; // r9
			//   Dictionary_2_System_ValueTuple_2_Int32_Int32_UnityEngine_RectInt_ *v19; // rax
			//   Dictionary_2_System_ValueTuple_2_Int32_Int32_UnityEngine_RectInt_ *v20; // rdi
			//   OneofDescriptorProto *v21; // rdx
			//   FileDescriptor *v22; // r8
			//   MessageDescriptor *v23; // r9
			//   String__Array *v24; // [rsp+20h] [rbp-18h] BYREF
			//   String *v25; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v26; // [rsp+30h] [rbp-8h]
			// 
			//   if ( !byte_18D8ED9EE )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<int,int>,UnityEngine::RectInt>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<int,int>,UnityEngine::RectInt>::Dictionary);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::Dictionary<System::ValueTuple<int,int>,UnityEngine::RectInt>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::List);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<UnityEngine::RectInt>);
			//     byte_18D8ED9EE = 1;
			//   }
			//   v7 = (LowLevelList_1_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<UnityEngine::RectInt>);
			//   v10 = (List_1_UnityEngine_RectInt_ *)v7;
			//   if ( !v7 )
			//     goto LABEL_10;
			//   System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
			//     v7,
			//     MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::List);
			//   this.fields.m_newFreeRectangles = v10;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.m_newFreeRectangles, v11, v12, v13, v24, v25, v26);
			//   v14 = (LowLevelList_1_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<UnityEngine::RectInt>);
			//   v15 = (List_1_UnityEngine_RectInt_ *)v14;
			//   if ( !v14 )
			//     goto LABEL_10;
			//   System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
			//     v14,
			//     MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::List);
			//   this.fields.m_freeRectangles = v15;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.m_freeRectangles, v16, v17, v18, v24, v25, v26);
			//   v19 = (Dictionary_2_System_ValueTuple_2_Int32_Int32_UnityEngine_RectInt_ *)sub_180004920(TypeInfo::System::Collections::Generic::Dictionary<System::ValueTuple<int,int>,UnityEngine::RectInt>);
			//   v20 = v19;
			//   if ( !v19 )
			//     goto LABEL_10;
			//   System::Collections::Generic::Dictionary<System::ValueTuple<int,int>,UnityEngine::RectInt>::Dictionary(
			//     v19,
			//     MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<int,int>,UnityEngine::RectInt>::Dictionary);
			//   this.fields.m_usedRectangles = v20;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.m_usedRectangles, v21, v22, v23, v24, v25, v26);
			//   m_usedRectangles = (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)this.fields.m_usedRectangles;
			//   this.fields.m_binWidth = width;
			//   this.fields.m_binHeight = height;
			//   this.fields.m_usedRectSize = 0;
			//   this.fields.m_maxFreeRectWidth = width;
			//   this.fields.m_maxFreeRectHeight = height;
			//   if ( !m_usedRectangles
			//     || (System::Collections::Generic::Dictionary<Beyond::Gameplay::WorldSetting::MissionImportanceAndType,System::Object>::Clear(
			//           m_usedRectangles,
			//           MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<int,int>,UnityEngine::RectInt>::Clear),
			//         (m_usedRectangles = (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)this.fields.m_freeRectangles) == 0LL)
			//     || (++HIDWORD(m_usedRectangles.fields._entries),
			//         LODWORD(m_usedRectangles.fields._entries) = 0,
			//         m_usedRectangles = (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)this.fields.m_freeRectangles,
			//         v24 = 0LL,
			//         v25 = (String *)__PAIR64__(height, width),
			//         !m_usedRectangles) )
			//   {
			// LABEL_10:
			//     sub_180B536AC(m_usedRectangles, v8);
			//   }
			//   sub_183320F80(m_usedRectangles, &v24, MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::Add);
			// }
			// 
		}

		public RectInt InsertRect(int width, int height)
		{
			// // RectInt InsertRect(Int32, Int32)
			// RectInt *HG::Rendering::Runtime::AtlasMaxRect::InsertRect(
			//         RectInt *__return_ptr retstr,
			//         AtlasMaxRect *this,
			//         int32_t width,
			//         int32_t height,
			//         MethodInfo *method)
			// {
			//   int v6; // r14d
			//   List_1_UnityEngine_RectInt_ *v9; // rdx
			//   __int64 v10; // rcx
			//   signed int v11; // r15d
			//   int32_t m_XMin; // r13d
			//   int32_t i; // edi
			//   List_1_UnityEngine_RectInt_ *m_freeRectangles; // rax
			//   uint32_t v15; // r14d
			//   RectInt v16; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   RectInt *result; // rax
			//   RectInt node; // [rsp+38h] [rbp-51h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v20; // [rsp+48h] [rbp-41h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v21; // [rsp+58h] [rbp-31h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v22; // [rsp+68h] [rbp-21h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v23; // [rsp+78h] [rbp-11h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v24; // [rsp+88h] [rbp-1h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v25; // [rsp+98h] [rbp+Fh] BYREF
			//   RectInt v26; // [rsp+A8h] [rbp+1Fh] BYREF
			// 
			//   v6 = width;
			//   if ( !byte_18D919478 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//     byte_18D919478 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1368, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1368, 0LL);
			//     if ( !Patch )
			// LABEL_25:
			//       sub_180B536AC(v10, v9);
			//     v16 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_517(&v26, Patch, (Object *)this, v6, height, 0LL);
			//   }
			//   else
			//   {
			//     v11 = 0x7FFFFFFF;
			//     node = 0LL;
			//     m_XMin = 0x7FFFFFFF;
			//     for ( i = 0; ; ++i )
			//     {
			//       m_freeRectangles = this.fields.m_freeRectangles;
			//       if ( !m_freeRectangles )
			//         goto LABEL_25;
			//       if ( i >= m_freeRectangles.fields._size )
			//         break;
			//       System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//         &v20,
			//         (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_freeRectangles,
			//         i,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//       if ( SLODWORD(v20.hdyeVnGBkdgGBgilyBhrVrxcQSQLA) >= v6 )
			//       {
			//         v9 = this.fields.m_freeRectangles;
			//         if ( !v9 )
			//           goto LABEL_25;
			//         System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//           &v21,
			//           (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)v9,
			//           i,
			//           MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//         if ( SHIDWORD(v21.hdyeVnGBkdgGBgilyBhrVrxcQSQLA) >= height )
			//         {
			//           v9 = this.fields.m_freeRectangles;
			//           if ( !v9 )
			//             goto LABEL_25;
			//           System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//             &v22,
			//             (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)v9,
			//             i,
			//             MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//           v15 = height + v22.DoaPxMFAmfwLwshNWtiPzjXtBZNn;
			//           if ( (signed int)(height + v22.DoaPxMFAmfwLwshNWtiPzjXtBZNn) < v11 )
			//             goto LABEL_15;
			//           if ( v15 == v11 )
			//           {
			//             v9 = this.fields.m_freeRectangles;
			//             if ( !v9 )
			//               goto LABEL_25;
			//             System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//               &v23,
			//               (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)v9,
			//               i,
			//               MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//             if ( v23.EEjhUIhIcsWLXXeGfefLxEjqKdgQ < m_XMin )
			//             {
			// LABEL_15:
			//               v9 = this.fields.m_freeRectangles;
			//               if ( !v9 )
			//                 goto LABEL_25;
			//               System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//                 &v24,
			//                 (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)v9,
			//                 i,
			//                 MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//               v9 = this.fields.m_freeRectangles;
			//               node.m_XMin = v24.EEjhUIhIcsWLXXeGfefLxEjqKdgQ;
			//               if ( !v9 )
			//                 goto LABEL_25;
			//               System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//                 &v25,
			//                 (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)v9,
			//                 i,
			//                 MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//               v11 = v15;
			//               v9 = this.fields.m_freeRectangles;
			//               node.m_YMin = v25.DoaPxMFAmfwLwshNWtiPzjXtBZNn;
			//               node.m_Width = width;
			//               node.m_Height = height;
			//               if ( !v9 )
			//                 goto LABEL_25;
			//               System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//                 (prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA *)&v26,
			//                 (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)v9,
			//                 i,
			//                 MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//               m_XMin = v26.m_XMin;
			//             }
			//           }
			//           v6 = width;
			//         }
			//       }
			//     }
			//     if ( node.m_Height )
			//       HG::Rendering::Runtime::AtlasMaxRect::_PlaceRect(this, &node, 0LL);
			//     v16 = node;
			//   }
			//   result = retstr;
			//   *retstr = v16;
			//   return result;
			// }
			// 
			return null;
		}

		public RectInt InsertRectBestShortSideFit(int width, int height)
		{
			// // RectInt InsertRectBestShortSideFit(Int32, Int32)
			// RectInt *HG::Rendering::Runtime::AtlasMaxRect::InsertRectBestShortSideFit(
			//         RectInt *__return_ptr retstr,
			//         AtlasMaxRect *this,
			//         int32_t width,
			//         int32_t height,
			//         MethodInfo *method)
			// {
			//   RectInt *PositionForNewNodeBestShortSideFit; // rax
			//   RectInt v10; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   RectInt *result; // rax
			//   int32_t v15; // [rsp+40h] [rbp-38h] BYREF
			//   RectInt node; // [rsp+48h] [rbp-30h] BYREF
			//   RectInt v17; // [rsp+58h] [rbp-20h] BYREF
			//   int32_t v18; // [rsp+80h] [rbp+8h] BYREF
			// 
			//   v15 = 0;
			//   v18 = 0;
			//   node = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2277, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2277, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, v12);
			//     PositionForNewNodeBestShortSideFit = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_517(
			//                                            &v17,
			//                                            Patch,
			//                                            (Object *)this,
			//                                            width,
			//                                            height,
			//                                            0LL);
			//     goto LABEL_7;
			//   }
			//   PositionForNewNodeBestShortSideFit = HG::Rendering::Runtime::AtlasMaxRect::_FindPositionForNewNodeBestShortSideFit(
			//                                          &v17,
			//                                          this,
			//                                          width,
			//                                          height,
			//                                          &v15,
			//                                          &v18,
			//                                          0LL);
			//   node = *PositionForNewNodeBestShortSideFit;
			//   if ( !_mm_srli_si128(*(__m128i *)&node, 8).m128i_u32[1] )
			//   {
			// LABEL_7:
			//     v10 = *PositionForNewNodeBestShortSideFit;
			//     goto LABEL_8;
			//   }
			//   HG::Rendering::Runtime::AtlasMaxRect::_PlaceRect(this, &node, 0LL);
			//   v10 = node;
			// LABEL_8:
			//   result = retstr;
			//   *retstr = v10;
			//   return result;
			// }
			// 
			return null;
		}

		public RectInt InsertRectContactPoint(int width, int height)
		{
			// // RectInt InsertRectContactPoint(Int32, Int32)
			// RectInt *HG::Rendering::Runtime::AtlasMaxRect::InsertRectContactPoint(
			//         RectInt *__return_ptr retstr,
			//         AtlasMaxRect *this,
			//         int32_t width,
			//         int32_t height,
			//         MethodInfo *method)
			// {
			//   RectInt *PositionForNewNodeContactPoint; // rax
			//   RectInt v10; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   RectInt *result; // rax
			//   RectInt node; // [rsp+30h] [rbp-28h] BYREF
			//   RectInt v16; // [rsp+40h] [rbp-18h] BYREF
			//   int32_t v17; // [rsp+60h] [rbp+8h] BYREF
			// 
			//   v17 = 0;
			//   node = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2279, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2279, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, v12);
			//     PositionForNewNodeContactPoint = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_517(
			//                                        &v16,
			//                                        Patch,
			//                                        (Object *)this,
			//                                        width,
			//                                        height,
			//                                        0LL);
			//     goto LABEL_7;
			//   }
			//   PositionForNewNodeContactPoint = HG::Rendering::Runtime::AtlasMaxRect::_FindPositionForNewNodeContactPoint(
			//                                      &v16,
			//                                      this,
			//                                      width,
			//                                      height,
			//                                      &v17,
			//                                      0LL);
			//   node = *PositionForNewNodeContactPoint;
			//   if ( !_mm_srli_si128(*(__m128i *)&node, 8).m128i_u32[1] )
			//   {
			// LABEL_7:
			//     v10 = *PositionForNewNodeContactPoint;
			//     goto LABEL_8;
			//   }
			//   HG::Rendering::Runtime::AtlasMaxRect::_PlaceRect(this, &node, 0LL);
			//   v10 = node;
			// LABEL_8:
			//   result = retstr;
			//   *retstr = v10;
			//   return result;
			// }
			// 
			return null;
		}

		public RectInt InsertRectBestLongSideFit(int width, int height)
		{
			// // RectInt InsertRectBestLongSideFit(Int32, Int32)
			// RectInt *HG::Rendering::Runtime::AtlasMaxRect::InsertRectBestLongSideFit(
			//         RectInt *__return_ptr retstr,
			//         AtlasMaxRect *this,
			//         int32_t width,
			//         int32_t height,
			//         MethodInfo *method)
			// {
			//   RectInt *PositionForNewNodeBestLongSideFit; // rax
			//   RectInt v10; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   RectInt *result; // rax
			//   int32_t v15; // [rsp+40h] [rbp-38h] BYREF
			//   RectInt node; // [rsp+48h] [rbp-30h] BYREF
			//   RectInt v17; // [rsp+58h] [rbp-20h] BYREF
			//   int32_t v18; // [rsp+80h] [rbp+8h] BYREF
			// 
			//   v15 = 0;
			//   v18 = 0;
			//   node = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2283, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2283, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, v12);
			//     PositionForNewNodeBestLongSideFit = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_517(
			//                                           &v17,
			//                                           Patch,
			//                                           (Object *)this,
			//                                           width,
			//                                           height,
			//                                           0LL);
			//     goto LABEL_7;
			//   }
			//   PositionForNewNodeBestLongSideFit = HG::Rendering::Runtime::AtlasMaxRect::_FindPositionForNewNodeBestLongSideFit(
			//                                         &v17,
			//                                         this,
			//                                         width,
			//                                         height,
			//                                         &v15,
			//                                         &v18,
			//                                         0LL);
			//   node = *PositionForNewNodeBestLongSideFit;
			//   if ( !_mm_srli_si128(*(__m128i *)&node, 8).m128i_u32[1] )
			//   {
			// LABEL_7:
			//     v10 = *PositionForNewNodeBestLongSideFit;
			//     goto LABEL_8;
			//   }
			//   HG::Rendering::Runtime::AtlasMaxRect::_PlaceRect(this, &node, 0LL);
			//   v10 = node;
			// LABEL_8:
			//   result = retstr;
			//   *retstr = v10;
			//   return result;
			// }
			// 
			return null;
		}

		public RectInt InsertRectBestAreaFit(int width, int height)
		{
			// // RectInt InsertRectBestAreaFit(Int32, Int32)
			// RectInt *HG::Rendering::Runtime::AtlasMaxRect::InsertRectBestAreaFit(
			//         RectInt *__return_ptr retstr,
			//         AtlasMaxRect *this,
			//         int32_t width,
			//         int32_t height,
			//         MethodInfo *method)
			// {
			//   RectInt *PositionForNewNodeBestAreaFit; // rax
			//   RectInt v10; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   RectInt *result; // rax
			//   int32_t v15; // [rsp+40h] [rbp-38h] BYREF
			//   RectInt node; // [rsp+48h] [rbp-30h] BYREF
			//   RectInt v17; // [rsp+58h] [rbp-20h] BYREF
			//   int32_t v18; // [rsp+80h] [rbp+8h] BYREF
			// 
			//   v15 = 0;
			//   v18 = 0;
			//   node = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2285, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2285, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, v12);
			//     PositionForNewNodeBestAreaFit = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_517(
			//                                       &v17,
			//                                       Patch,
			//                                       (Object *)this,
			//                                       width,
			//                                       height,
			//                                       0LL);
			//     goto LABEL_7;
			//   }
			//   PositionForNewNodeBestAreaFit = HG::Rendering::Runtime::AtlasMaxRect::_FindPositionForNewNodeBestAreaFit(
			//                                     &v17,
			//                                     this,
			//                                     width,
			//                                     height,
			//                                     &v15,
			//                                     &v18,
			//                                     0LL);
			//   node = *PositionForNewNodeBestAreaFit;
			//   if ( !_mm_srli_si128(*(__m128i *)&node, 8).m128i_u32[1] )
			//   {
			// LABEL_7:
			//     v10 = *PositionForNewNodeBestAreaFit;
			//     goto LABEL_8;
			//   }
			//   HG::Rendering::Runtime::AtlasMaxRect::_PlaceRect(this, &node, 0LL);
			//   v10 = node;
			// LABEL_8:
			//   result = retstr;
			//   *retstr = v10;
			//   return result;
			// }
			// 
			return null;
		}

		public void InsertRects(List<RectInt> rects, List<RectInt> dst, AtlasMaxRect.FreeRectChoiceHeuristic method)
		{
			// // Void InsertRects(List`1[UnityEngine.RectInt], List`1[UnityEngine.RectInt], AtlasMaxRect+FreeRectChoiceHeuristic)
			// void HG::Rendering::Runtime::AtlasMaxRect::InsertRects(
			//         AtlasMaxRect *this,
			//         List_1_UnityEngine_RectInt_ *rects,
			//         List_1_UnityEngine_RectInt_ *dst,
			//         AtlasMaxRect_FreeRectChoiceHeuristic__Enum method_1,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   int32_t v11; // r15d
			//   int32_t v12; // r14d
			//   int32_t v13; // r12d
			//   int32_t v14; // esi
			//   RectInt v15; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   int32_t v17; // [rsp+48h] [rbp-51h] BYREF
			//   int32_t v18[3]; // [rsp+4Ch] [rbp-4Dh] BYREF
			//   RectInt node; // [rsp+58h] [rbp-41h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v20; // [rsp+68h] [rbp-31h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v21; // [rsp+78h] [rbp-21h] BYREF
			//   RectInt v22; // [rsp+88h] [rbp-11h] BYREF
			//   RectInt v23; // [rsp+98h] [rbp-1h] BYREF
			//   RectInt v24; // [rsp+A8h] [rbp+Fh] BYREF
			// 
			//   if ( !byte_18D919479 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::RemoveAt);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::set_Item);
			//     byte_18D919479 = 1;
			//   }
			//   v18[0] = 0;
			//   v17 = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2287, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2287, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_103(
			//         (ILFixDynamicMethodWrapper_14 *)Patch,
			//         (Object *)this,
			//         (Object *)rects,
			//         (Object *)dst,
			//         (LogType__Enum)method_1,
			//         0LL);
			//       return;
			//     }
			// LABEL_17:
			//     sub_180B536AC(v10, v9);
			//   }
			//   if ( !dst )
			//     goto LABEL_17;
			//   ++dst.fields._version;
			//   dst.fields._size = 0;
			//   if ( !rects )
			//     goto LABEL_17;
			//   while ( rects.fields._size > 0 )
			//   {
			//     v11 = 0x7FFFFFFF;
			//     v12 = -1;
			//     v13 = 0x7FFFFFFF;
			//     v14 = 0;
			//     node = 0LL;
			//     while ( v14 < rects.fields._size )
			//     {
			//       System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//         &v21,
			//         (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)rects,
			//         v14,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//       System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//         &v20,
			//         (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)rects,
			//         v14,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//       v15 = *HG::Rendering::Runtime::AtlasMaxRect::_ScoreRect(
			//                &v24,
			//                this,
			//                (int32_t)v21.hdyeVnGBkdgGBgilyBhrVrxcQSQLA,
			//                SHIDWORD(v20.hdyeVnGBkdgGBgilyBhrVrxcQSQLA),
			//                method_1,
			//                v18,
			//                &v17,
			//                0LL);
			//       if ( v18[0] < v11 || v18[0] == v11 && v17 < v13 )
			//       {
			//         v13 = v17;
			//         v11 = v18[0];
			//         node = v15;
			//         v12 = v14;
			//       }
			//       ++v14;
			//     }
			//     if ( v12 == -1 )
			//       break;
			//     HG::Rendering::Runtime::AtlasMaxRect::_PlaceRect(this, &node, 0LL);
			//     v22 = node;
			//     sub_183320F80(dst, &v22, MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::Add);
			//     System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//       (prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA *)&v23,
			//       (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)rects,
			//       rects.fields._size - 1,
			//       MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//     v22 = v23;
			//     System::Collections::Generic::List<Beyond::NPC::Animation::NPCCrowdLodSettingConfig::FNPCCrowdLodSetting>::set_Item(
			//       (List_1_Beyond_NPC_Animation_NPCCrowdLodSettingConfig_FNPCCrowdLodSetting_ *)rects,
			//       v12,
			//       (NPCCrowdLodSettingConfig_FNPCCrowdLodSetting *)&v22,
			//       MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::set_Item);
			//     System::Collections::Generic::List<Cinemachine::TargetPositionCache_CacheEntry::RecordingItem>::RemoveAt(
			//       (List_1_Cinemachine_TargetPositionCache_CacheEntry_RecordingItem_ *)rects,
			//       rects.fields._size - 1,
			//       MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::RemoveAt);
			//   }
			// }
			// 
		}

		public void RemoveRect(in RectInt rect)
		{
			// // Void RemoveRect(RectInt ByRef)
			// void HG::Rendering::Runtime::AtlasMaxRect::RemoveRect(AtlasMaxRect *this, RectInt *rect, MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   Dictionary_2_System_ValueTuple_2_Int32_Int32_UnityEngine_RectInt_ *m_usedRectangles; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ValueTuple_2_Int32_Int32_ key; // [rsp+58h] [rbp+20h]
			// 
			//   if ( !byte_18D91947A )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<int,int>,UnityEngine::RectInt>::Remove);
			//     sub_18003C530(&MethodInfo::HG::Rendering::HGRPLogger::LogError<int,int,int,int>);
			//     sub_18003C530(&MethodInfo::System::ValueTuple<int,int>::ValueTuple);
			//     sub_18003C530(&off_18D4EB950);
			//     byte_18D91947A = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1356, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1356, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_514(Patch, (Object *)this, rect, 0LL);
			//       return;
			//     }
			// LABEL_10:
			//     sub_180B536AC(m_usedRectangles, v5);
			//   }
			//   HG::Rendering::Runtime::AtlasMaxRect::_PlaceFreeRect(this, rect, 0LL);
			//   m_usedRectangles = this.fields.m_usedRectangles;
			//   key.Item1 = _mm_cvtsi128_si32(*(__m128i *)rect);
			//   if ( !m_usedRectangles )
			//     goto LABEL_10;
			//   key.Item2 = HIDWORD(*(_QWORD *)&rect.m_XMin);
			//   if ( System::Collections::Generic::Dictionary<System::ValueTuple<int,int>,UnityEngine::RectInt>::Remove(
			//          m_usedRectangles,
			//          key,
			//          MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<int,int>,UnityEngine::RectInt>::Remove) )
			//   {
			//     this.fields.m_usedRectSize -= *(_QWORD *)&rect.m_Width * HIDWORD(*(_QWORD *)&rect.m_Width);
			//   }
			//   else
			//   {
			//     HG::Rendering::HGRPLogger::LogError<int,int,int,int>(
			//       (String *)"Trying to remove a rectangle that has not been inserted: (x,y)=({0},{1}) (w,h)=({2},{3})",
			//       *(_QWORD *)&rect.m_XMin,
			//       HIDWORD(*(_QWORD *)&rect.m_XMin),
			//       *(_QWORD *)&rect.m_Width,
			//       HIDWORD(*(_QWORD *)&rect.m_Width),
			//       MethodInfo::HG::Rendering::HGRPLogger::LogError<int,int,int,int>);
			//   }
			//   HG::Rendering::Runtime::AtlasMaxRect::_RecalculateMaxFreeRectWidthHeight(this, 0LL);
			// }
			// 
		}

		public void FreeRects(List<RectInt> rects)
		{
			// // Void FreeRects(List`1[UnityEngine.RectInt])
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::AtlasMaxRect::FreeRects(
			//         AtlasMaxRect *this,
			//         List_1_UnityEngine_RectInt_ *rects,
			//         MethodInfo *method)
			// {
			//   AtlasMaxRect *v4; // rbx
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   __int64 v7; // rdx
			//   Dictionary_2_System_ValueTuple_2_Int32_Int32_UnityEngine_RectInt_ *m_usedRectangles; // rcx
			//   int32_t m_XMin; // edi
			//   int32_t m_YMin; // esi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   Il2CppExceptionWrapper *v14; // [rsp+30h] [rbp-68h] BYREF
			//   RectInt node; // [rsp+38h] [rbp-60h] BYREF
			//   List_1_T_Enumerator_Beyond_NPC_Animation_NPCCrowdLodSettingConfig_FNPCCrowdLodSetting_ v16; // [rsp+48h] [rbp-50h] BYREF
			//   List_1_T_Enumerator_Beyond_NPC_Animation_NPCCrowdLodSettingConfig_FNPCCrowdLodSetting_ v17; // [rsp+68h] [rbp-30h] BYREF
			// 
			//   v4 = this;
			//   if ( !byte_18D91947B )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<int,int>,UnityEngine::RectInt>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::RectInt>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::RectInt>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::RectInt>::get_Current);
			//     sub_18003C530(&MethodInfo::HG::Rendering::HGRPLogger::LogError<int,int,int,int>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::ValueTuple<int,int>::ValueTuple);
			//     sub_18003C530(&off_18D4EB3B8);
			//     byte_18D91947B = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2290, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2290, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, v12);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)v4,
			//       (Object *)rects,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( !rects )
			//       sub_180B536AC(v6, v5);
			//     System::Collections::Generic::List<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::CoreZoneEntry>::GetEnumerator(
			//       (List_1_T_Enumerator_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)&v16,
			//       (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)rects,
			//       MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::GetEnumerator);
			//     v17 = v16;
			//     v16._list = 0LL;
			//     *(_QWORD *)&v16._index = &v17;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::NPC::Animation::NPCCrowdLodSettingConfig::FNPCCrowdLodSetting>::MoveNext(
			//                 &v17,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::RectInt>::MoveNext) )
			//       {
			//         node = (RectInt)v17._current;
			//         HG::Rendering::Runtime::AtlasMaxRect::_PlaceFreeRect(v4, &node, 0LL);
			//         m_usedRectangles = v4.fields.m_usedRectangles;
			//         m_XMin = node.m_XMin;
			//         m_YMin = node.m_YMin;
			//         if ( !m_usedRectangles )
			//           sub_1802DC2C8(0LL, v7);
			//         if ( System::Collections::Generic::Dictionary<System::ValueTuple<int,int>,UnityEngine::RectInt>::Remove(
			//                m_usedRectangles,
			//                *(ValueTuple_2_Int32_Int32_ *)&node.m_XMin,
			//                MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<int,int>,UnityEngine::RectInt>::Remove) )
			//         {
			//           v4.fields.m_usedRectSize -= node.m_Width * node.m_Height;
			//         }
			//         else
			//         {
			//           HG::Rendering::HGRPLogger::LogError<int,int,int,int>(
			//             (String *)"Trying to remove a rectangle that has not been inserted:  (x,y)=({0},{1}) (w,h)=({2},{3})",
			//             m_XMin,
			//             m_YMin,
			//             node.m_Width,
			//             node.m_Height,
			//             MethodInfo::HG::Rendering::HGRPLogger::LogError<int,int,int,int>);
			//         }
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v14 )
			//     {
			//       v16._list = (List_1_Beyond_NPC_Animation_NPCCrowdLodSettingConfig_FNPCCrowdLodSetting_ *)v14.ex;
			//       if ( v16._list )
			//         sub_18000F780(v16._list);
			//       v4 = this;
			//     }
			//     HG::Rendering::Runtime::AtlasMaxRect::_RecalculateMaxFreeRectWidthHeight(v4, 0LL);
			//   }
			// }
			// 
		}

		public void Reset()
		{
			// // Void Reset()
			// void HG::Rendering::Runtime::AtlasMaxRect::Reset(AtlasMaxRect *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *m_usedRectangles; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   _QWORD v6[3]; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8ED9EF )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<int,int>,UnityEngine::RectInt>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::Clear);
			//     byte_18D8ED9EF = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1353, 0LL) )
			//   {
			//     m_usedRectangles = (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)this.fields.m_usedRectangles;
			//     this.fields.m_maxFreeRectWidth = this.fields.m_binWidth;
			//     this.fields.m_maxFreeRectHeight = this.fields.m_binHeight;
			//     this.fields.m_usedRectSize = 0;
			//     if ( m_usedRectangles )
			//     {
			//       System::Collections::Generic::Dictionary<Beyond::Gameplay::WorldSetting::MissionImportanceAndType,System::Object>::Clear(
			//         m_usedRectangles,
			//         MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<int,int>,UnityEngine::RectInt>::Clear);
			//       m_usedRectangles = (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)this.fields.m_freeRectangles;
			//       if ( m_usedRectangles )
			//       {
			//         ++HIDWORD(m_usedRectangles.fields._entries);
			//         LODWORD(m_usedRectangles.fields._entries) = 0;
			//         m_usedRectangles = (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)this.fields.m_freeRectangles;
			//         v6[1] = *(_QWORD *)&this.fields.m_binWidth;
			//         v6[0] = 0LL;
			//         if ( m_usedRectangles )
			//         {
			//           sub_183320F80(m_usedRectangles, v6, MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::Add);
			//           return;
			//         }
			//       }
			//     }
			// LABEL_8:
			//     sub_180B536AC(m_usedRectangles, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1353, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private void _PlaceRect(in RectInt node)
		{
			// // Void _PlaceRect(RectInt ByRef)
			// void HG::Rendering::Runtime::AtlasMaxRect::_PlaceRect(AtlasMaxRect *this, RectInt *node, MethodInfo *method)
			// {
			//   List_1_UnityEngine_RectInt_ *v5; // rdx
			//   Dictionary_2_System_ValueTuple_2_Int32_Int32_UnityEngine_RectInt_ *m_usedRectangles; // rcx
			//   int32_t v7; // edi
			//   List_1_UnityEngine_RectInt_ *m_freeRectangles; // rax
			//   List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *v9; // r14
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   RectInt freeNode; // [rsp+20h] [rbp-40h] BYREF
			//   RectInt v12; // [rsp+30h] [rbp-30h] BYREF
			//   RectInt v13; // [rsp+40h] [rbp-20h] BYREF
			//   RectInt v14; // [rsp+50h] [rbp-10h] BYREF
			//   ValueTuple_2_Int32_Int32_ v15; // [rsp+98h] [rbp+38h]
			// 
			//   if ( !byte_18D91947C )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<int,int>,UnityEngine::RectInt>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::RemoveAt);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::set_Item);
			//     sub_18003C530(&MethodInfo::System::ValueTuple<int,int>::ValueTuple);
			//     byte_18D91947C = 1;
			//   }
			//   freeNode = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1369, 0LL) )
			//   {
			//     v7 = 0;
			//     while ( 1 )
			//     {
			//       m_freeRectangles = this.fields.m_freeRectangles;
			//       if ( !m_freeRectangles )
			//         goto LABEL_15;
			//       if ( v7 >= m_freeRectangles.fields._size )
			//         break;
			//       System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//         (prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA *)&v12,
			//         (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_freeRectangles,
			//         v7,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//       freeNode = v12;
			//       if ( HG::Rendering::Runtime::AtlasMaxRect::_SplitFreeNode(this, &freeNode, node, 0LL) )
			//       {
			//         v9 = (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_freeRectangles;
			//         v5 = (List_1_UnityEngine_RectInt_ *)v9;
			//         if ( !v9 )
			//           goto LABEL_15;
			//         System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//           (prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA *)&v13,
			//           v9,
			//           v9.fields._size - 1,
			//           MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//         v14 = v13;
			//         System::Collections::Generic::List<Beyond::NPC::Animation::NPCCrowdLodSettingConfig::FNPCCrowdLodSetting>::set_Item(
			//           (List_1_Beyond_NPC_Animation_NPCCrowdLodSettingConfig_FNPCCrowdLodSetting_ *)v9,
			//           v7,
			//           (NPCCrowdLodSettingConfig_FNPCCrowdLodSetting *)&v14,
			//           MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::set_Item);
			//         v5 = this.fields.m_freeRectangles;
			//         if ( !v5 )
			//           goto LABEL_15;
			//         System::Collections::Generic::List<Cinemachine::TargetPositionCache_CacheEntry::RecordingItem>::RemoveAt(
			//           (List_1_Cinemachine_TargetPositionCache_CacheEntry_RecordingItem_ *)this.fields.m_freeRectangles,
			//           v5.fields._size - 1,
			//           MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::RemoveAt);
			//       }
			//       else
			//       {
			//         ++v7;
			//       }
			//     }
			//     HG::Rendering::Runtime::AtlasMaxRect::_PruneFreeList(this, 0LL);
			//     m_usedRectangles = this.fields.m_usedRectangles;
			//     freeNode = *node;
			//     v15 = (ValueTuple_2_Int32_Int32_)__PAIR64__(freeNode.m_YMin, _mm_cvtsi128_si32((__m128i)freeNode));
			//     if ( m_usedRectangles )
			//     {
			//       v14 = freeNode;
			//       System::Collections::Generic::Dictionary<System::ValueTuple<int,int>,UnityEngine::RectInt>::Add(
			//         m_usedRectangles,
			//         v15,
			//         &v14,
			//         MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<int,int>,UnityEngine::RectInt>::Add);
			//       this.fields.m_usedRectSize += *(_QWORD *)&node.m_Width * HIDWORD(*(_QWORD *)&node.m_Width);
			//       return;
			//     }
			// LABEL_15:
			//     sub_180B536AC(m_usedRectangles, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1369, 0LL);
			//   if ( !Patch )
			//     goto LABEL_15;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_514(Patch, (Object *)this, node, 0LL);
			// }
			// 
		}

		private RectInt _ScoreRect(int width, int height, AtlasMaxRect.FreeRectChoiceHeuristic method, out int score1, out int score2)
		{
			// // RectInt _ScoreRect(Int32, Int32, AtlasMaxRect+FreeRectChoiceHeuristic, Int32 ByRef, Int32 ByRef)
			// RectInt *HG::Rendering::Runtime::AtlasMaxRect::_ScoreRect(
			//         RectInt *__return_ptr retstr,
			//         AtlasMaxRect *this,
			//         int32_t width,
			//         int32_t height,
			//         AtlasMaxRect_FreeRectChoiceHeuristic__Enum method_1,
			//         int32_t *score1,
			//         int32_t *score2,
			//         MethodInfo *method)
			// {
			//   __m128i v12; // xmm1
			//   RectInt *PositionForNewNodeBestLongSideFit; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v15; // rcx
			//   RectInt v17; // [rsp+50h] [rbp-28h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2288, 0LL) )
			//   {
			//     v12 = 0LL;
			//     *score1 = 0x7FFFFFFF;
			//     *score2 = 0x7FFFFFFF;
			//     if ( method_1 )
			//     {
			//       if ( method_1 == AtlasMaxRect_FreeRectChoiceHeuristic__Enum_RectBestLongSideFit )
			//       {
			//         PositionForNewNodeBestLongSideFit = HG::Rendering::Runtime::AtlasMaxRect::_FindPositionForNewNodeBestLongSideFit(
			//                                               &v17,
			//                                               this,
			//                                               width,
			//                                               height,
			//                                               score2,
			//                                               score1,
			//                                               0LL);
			//       }
			//       else if ( method_1 == AtlasMaxRect_FreeRectChoiceHeuristic__Enum_RectBestAreaFit )
			//       {
			//         PositionForNewNodeBestLongSideFit = HG::Rendering::Runtime::AtlasMaxRect::_FindPositionForNewNodeBestAreaFit(
			//                                               &v17,
			//                                               this,
			//                                               width,
			//                                               height,
			//                                               score1,
			//                                               score2,
			//                                               0LL);
			//       }
			//       else
			//       {
			//         if ( method_1 != AtlasMaxRect_FreeRectChoiceHeuristic__Enum_RectBottomLeftRule )
			//         {
			//           if ( method_1 == AtlasMaxRect_FreeRectChoiceHeuristic__Enum_RectContactPointRule )
			//           {
			//             v12 = *(__m128i *)HG::Rendering::Runtime::AtlasMaxRect::_FindPositionForNewNodeContactPoint(
			//                                 &v17,
			//                                 this,
			//                                 width,
			//                                 height,
			//                                 score1,
			//                                 0LL);
			//             *score1 = -*score1;
			//           }
			//           goto LABEL_13;
			//         }
			//         PositionForNewNodeBestLongSideFit = HG::Rendering::Runtime::AtlasMaxRect::_FindPositionForNewNodeBottomLeft(
			//                                               &v17,
			//                                               this,
			//                                               width,
			//                                               height,
			//                                               score1,
			//                                               score2,
			//                                               0LL);
			//       }
			//     }
			//     else
			//     {
			//       PositionForNewNodeBestLongSideFit = HG::Rendering::Runtime::AtlasMaxRect::_FindPositionForNewNodeBestShortSideFit(
			//                                             &v17,
			//                                             this,
			//                                             width,
			//                                             height,
			//                                             score1,
			//                                             score2,
			//                                             0LL);
			//     }
			//     v12 = *(__m128i *)PositionForNewNodeBestLongSideFit;
			// LABEL_13:
			//     if ( !_mm_srli_si128(v12, 8).m128i_u32[1] )
			//     {
			//       *score1 = 0x7FFFFFFF;
			//       *score2 = 0x7FFFFFFF;
			//     }
			//     *retstr = (RectInt)v12;
			//     return retstr;
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2288, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v15, 0LL);
			//   *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_825(
			//                &v17,
			//                Patch,
			//                (Object *)this,
			//                width,
			//                height,
			//                method_1,
			//                score1,
			//                score2,
			//                0LL);
			//   return retstr;
			// }
			// 
			return null;
		}

		private bool _SplitFreeNode(in RectInt freeNode, in RectInt usedNode)
		{
			// // Boolean _SplitFreeNode(RectInt ByRef, RectInt ByRef)
			// bool HG::Rendering::Runtime::AtlasMaxRect::_SplitFreeNode(
			//         AtlasMaxRect *this,
			//         RectInt *freeNode,
			//         RectInt *usedNode,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   List_1_UnityEngine_RectInt_ *m_newFreeRectangles; // rax
			//   __int64 v11; // rdx
			//   RectInt v12; // xmm0
			//   __int64 v13; // rdx
			//   __int64 v14; // r8
			//   __int64 v15; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   int32_t newFreeRectanglesLastSize; // [rsp+30h] [rbp-20h] BYREF
			//   RectInt newFreeRect; // [rsp+38h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D91947D )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Count);
			//     byte_18D91947D = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1370, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1370, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_511(Patch, (Object *)this, freeNode, usedNode, 0LL);
			// LABEL_26:
			//     sub_180B536AC(v9, v8);
			//   }
			//   v7 = *(_QWORD *)&usedNode.m_XMin;
			//   if ( (int)*(_QWORD *)&usedNode.m_XMin >= (int)(*(_QWORD *)&freeNode.m_Width + *(_QWORD *)&freeNode.m_XMin) )
			//     return 0;
			//   if ( (int)(v7 + *(_QWORD *)&usedNode.m_Width) <= (int)*(_QWORD *)&freeNode.m_XMin )
			//     return 0;
			//   if ( SHIDWORD(v7) >= (int)(HIDWORD(*(_QWORD *)&freeNode.m_XMin) + HIDWORD(*(_QWORD *)&freeNode.m_Width)) )
			//     return 0;
			//   v8 = HIDWORD(*(_QWORD *)&usedNode.m_XMin);
			//   v9 = HIDWORD(*(_QWORD *)&freeNode.m_XMin);
			//   if ( (int)(v8 + HIDWORD(*(_QWORD *)&usedNode.m_Width)) <= (int)v9 )
			//     return 0;
			//   m_newFreeRectangles = this.fields.m_newFreeRectangles;
			//   if ( !m_newFreeRectangles )
			//     goto LABEL_26;
			//   newFreeRectanglesLastSize = m_newFreeRectangles.fields._size;
			//   v11 = *(_QWORD *)&usedNode.m_XMin;
			//   if ( (int)*(_QWORD *)&usedNode.m_XMin < (int)(*(_QWORD *)&freeNode.m_Width + *(_QWORD *)&freeNode.m_XMin)
			//     && (int)(v11 + *(_QWORD *)&usedNode.m_Width) > (int)*(_QWORD *)&freeNode.m_XMin )
			//   {
			//     if ( SHIDWORD(v11) > (int)HIDWORD(*(_QWORD *)&freeNode.m_XMin)
			//       && SHIDWORD(v11) < (int)(HIDWORD(*(_QWORD *)&freeNode.m_XMin) + HIDWORD(*(_QWORD *)&freeNode.m_Width)) )
			//     {
			//       newFreeRect = *freeNode;
			//       newFreeRect.m_Height = HIDWORD(*(_QWORD *)&usedNode.m_XMin) - newFreeRect.m_YMin;
			//       HG::Rendering::Runtime::AtlasMaxRect::_InsertNewFreeRectangle(this, &newFreeRect, &newFreeRectanglesLastSize, 0LL);
			//     }
			//     if ( (int)(HIDWORD(*(_QWORD *)&usedNode.m_Width) + HIDWORD(*(_QWORD *)&usedNode.m_XMin)) < (int)(HIDWORD(*(_QWORD *)&freeNode.m_XMin) + HIDWORD(*(_QWORD *)&freeNode.m_Width)) )
			//     {
			//       newFreeRect = *freeNode;
			//       newFreeRect.m_YMin = HIDWORD(*(_QWORD *)&usedNode.m_XMin) + HIDWORD(*(_QWORD *)&usedNode.m_Width);
			//       newFreeRect.m_Height = HIDWORD(*(_QWORD *)&freeNode.m_XMin)
			//                            + HIDWORD(*(_QWORD *)&freeNode.m_Width)
			//                            - HIDWORD(*(_QWORD *)&usedNode.m_Width)
			//                            - HIDWORD(*(_QWORD *)&usedNode.m_XMin);
			//       HG::Rendering::Runtime::AtlasMaxRect::_InsertNewFreeRectangle(this, &newFreeRect, &newFreeRectanglesLastSize, 0LL);
			//     }
			//   }
			//   if ( (int)HIDWORD(*(_QWORD *)&usedNode.m_XMin) < (int)(HIDWORD(*(_QWORD *)&freeNode.m_XMin)
			//                                                         + HIDWORD(*(_QWORD *)&freeNode.m_Width)) )
			//   {
			//     v12 = *freeNode;
			//     if ( (int)(HIDWORD(*(_QWORD *)&usedNode.m_Width) + HIDWORD(*(_QWORD *)&usedNode.m_XMin)) > (int)HIDWORD(*(_QWORD *)&freeNode.m_XMin) )
			//     {
			//       if ( (int)*(_QWORD *)&usedNode.m_XMin > v12.m_XMin )
			//       {
			//         v13 = *(_QWORD *)&usedNode.m_XMin;
			//         if ( (int)*(_QWORD *)&usedNode.m_XMin < (int)(*(_QWORD *)&freeNode.m_Width + v12.m_XMin) )
			//         {
			//           newFreeRect = *freeNode;
			//           newFreeRect.m_Width = v13 - _mm_cvtsi128_si32((__m128i)v12);
			//           HG::Rendering::Runtime::AtlasMaxRect::_InsertNewFreeRectangle(
			//             this,
			//             &newFreeRect,
			//             &newFreeRectanglesLastSize,
			//             0LL);
			//         }
			//       }
			//       v14 = *(_QWORD *)&usedNode.m_XMin;
			//       v15 = *(_QWORD *)&usedNode.m_Width;
			//       if ( (int)(v15 + *(_QWORD *)&usedNode.m_XMin) < (int)(*(_QWORD *)&freeNode.m_Width + *(_OWORD *)freeNode) )
			//       {
			//         newFreeRect = *freeNode;
			//         newFreeRect.m_XMin = v15 + v14;
			//         newFreeRect.m_Width = *(_QWORD *)&freeNode.m_XMin
			//                             + *(_QWORD *)&freeNode.m_Width
			//                             - v15
			//                             - *(_QWORD *)&usedNode.m_XMin;
			//         HG::Rendering::Runtime::AtlasMaxRect::_InsertNewFreeRectangle(
			//           this,
			//           &newFreeRect,
			//           &newFreeRectanglesLastSize,
			//           0LL);
			//       }
			//     }
			//   }
			//   return 1;
			// }
			// 
			return default(bool);
		}

		private void _InsertNewFreeRectangle(in RectInt newFreeRect, ref int newFreeRectanglesLastSize)
		{
			// // Void _InsertNewFreeRectangle(RectInt ByRef, Int32 ByRef)
			// void HG::Rendering::Runtime::AtlasMaxRect::_InsertNewFreeRectangle(
			//         AtlasMaxRect *this,
			//         RectInt *newFreeRect,
			//         int32_t *newFreeRectanglesLastSize,
			//         MethodInfo *method)
			// {
			//   List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *m_newFreeRectangles; // rdx
			//   List_1_UnityEngine_RectInt_ *v8; // rcx
			//   int32_t v9; // esi
			//   List_1_UnityEngine_RectInt_ *v10; // r15
			//   int32_t v11; // r8d
			//   List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *v12; // r15
			//   int32_t v13; // r12d
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   RectInt b; // [rsp+30h] [rbp-50h] BYREF
			//   RectInt v16; // [rsp+40h] [rbp-40h] BYREF
			//   RectInt v17; // [rsp+50h] [rbp-30h] BYREF
			//   RectInt v18; // [rsp+60h] [rbp-20h] BYREF
			//   RectInt v19; // [rsp+70h] [rbp-10h] BYREF
			// 
			//   if ( !byte_18D91947E )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::RemoveAt);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::set_Item);
			//     byte_18D91947E = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1371, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1371, 0LL);
			//     if ( !Patch )
			//       goto LABEL_18;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_516(Patch, (Object *)this, newFreeRect, newFreeRectanglesLastSize, 0LL);
			//   }
			//   else
			//   {
			//     v9 = 0;
			//     if ( *newFreeRectanglesLastSize > 0 )
			//     {
			//       while ( 1 )
			//       {
			//         m_newFreeRectangles = (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_newFreeRectangles;
			//         if ( !m_newFreeRectangles )
			//           break;
			//         System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//           (prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA *)&v16,
			//           m_newFreeRectangles,
			//           v9,
			//           MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//         b = v16;
			//         if ( HG::Rendering::Runtime::AtlasMaxRect::_IsContainedIn(this, newFreeRect, &b, 0LL) )
			//           return;
			//         m_newFreeRectangles = (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_newFreeRectangles;
			//         if ( !m_newFreeRectangles )
			//           break;
			//         System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//           (prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA *)&v17,
			//           m_newFreeRectangles,
			//           v9,
			//           MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//         b = v17;
			//         if ( HG::Rendering::Runtime::AtlasMaxRect::_IsContainedIn(this, &b, newFreeRect, 0LL) )
			//         {
			//           v10 = this.fields.m_newFreeRectangles;
			//           m_newFreeRectangles = (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)v10;
			//           v11 = *newFreeRectanglesLastSize - 1;
			//           *newFreeRectanglesLastSize = v11;
			//           if ( !v10 )
			//             break;
			//           System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//             (prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA *)&v18,
			//             (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)v10,
			//             v11,
			//             MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//           b = v18;
			//           System::Collections::Generic::List<Beyond::NPC::Animation::NPCCrowdLodSettingConfig::FNPCCrowdLodSetting>::set_Item(
			//             (List_1_Beyond_NPC_Animation_NPCCrowdLodSettingConfig_FNPCCrowdLodSetting_ *)v10,
			//             v9,
			//             (NPCCrowdLodSettingConfig_FNPCCrowdLodSetting *)&b,
			//             MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::set_Item);
			//           v12 = (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_newFreeRectangles;
			//           v13 = *newFreeRectanglesLastSize;
			//           m_newFreeRectangles = v12;
			//           if ( !v12 )
			//             break;
			//           System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//             (prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA *)&v19,
			//             v12,
			//             v12.fields._size - 1,
			//             MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//           b = v19;
			//           System::Collections::Generic::List<Beyond::NPC::Animation::NPCCrowdLodSettingConfig::FNPCCrowdLodSetting>::set_Item(
			//             (List_1_Beyond_NPC_Animation_NPCCrowdLodSettingConfig_FNPCCrowdLodSetting_ *)v12,
			//             v13,
			//             (NPCCrowdLodSettingConfig_FNPCCrowdLodSetting *)&b,
			//             MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::set_Item);
			//           m_newFreeRectangles = (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_newFreeRectangles;
			//           if ( !m_newFreeRectangles )
			//             break;
			//           System::Collections::Generic::List<Cinemachine::TargetPositionCache_CacheEntry::RecordingItem>::RemoveAt(
			//             (List_1_Cinemachine_TargetPositionCache_CacheEntry_RecordingItem_ *)this.fields.m_newFreeRectangles,
			//             m_newFreeRectangles.fields._size - 1,
			//             MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::RemoveAt);
			//         }
			//         else
			//         {
			//           ++v9;
			//         }
			//         if ( v9 >= *newFreeRectanglesLastSize )
			//           goto LABEL_15;
			//       }
			// LABEL_18:
			//       sub_180B536AC(v8, m_newFreeRectangles);
			//     }
			// LABEL_15:
			//     v8 = this.fields.m_newFreeRectangles;
			//     if ( !v8 )
			//       goto LABEL_18;
			//     v19 = *newFreeRect;
			//     sub_183320F80(v8, &v19, MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::Add);
			//   }
			// }
			// 
		}

		private void _PruneFreeList()
		{
			// // Void _PruneFreeList()
			// void HG::Rendering::Runtime::AtlasMaxRect::_PruneFreeList(AtlasMaxRect *this, MethodInfo *method)
			// {
			//   List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *v3; // rdx
			//   List_1_UnityEngine_RectInt_ *m_newFreeRectangles; // rcx
			//   int32_t i; // edi
			//   List_1_UnityEngine_RectInt_ *m_freeRectangles; // rax
			//   int32_t j; // esi
			//   List_1_UnityEngine_RectInt_ *v8; // rax
			//   List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *v9; // rsi
			//   int32_t v10; // r14d
			//   List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *v11; // r14
			//   int32_t v12; // r15d
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   RectInt b; // [rsp+28h] [rbp-39h] BYREF
			//   RectInt a; // [rsp+38h] [rbp-29h] BYREF
			//   RectInt v16; // [rsp+48h] [rbp-19h] BYREF
			//   RectInt v17; // [rsp+58h] [rbp-9h] BYREF
			//   RectInt v18; // [rsp+68h] [rbp+7h] BYREF
			//   RectInt v19; // [rsp+78h] [rbp+17h] BYREF
			//   RectInt v20; // [rsp+88h] [rbp+27h] BYREF
			//   RectInt v21; // [rsp+98h] [rbp+37h] BYREF
			// 
			//   if ( !byte_18D91947F )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::AddRange);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::RemoveAt);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::set_Item);
			//     byte_18D91947F = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1372, 0LL) )
			//   {
			//     for ( i = 0; ; ++i )
			//     {
			//       m_freeRectangles = this.fields.m_freeRectangles;
			//       if ( !m_freeRectangles )
			//         goto LABEL_26;
			//       if ( i >= m_freeRectangles.fields._size )
			//       {
			//         System::Collections::Generic::List<UnityEngine::RectInt>::AddRange(
			//           this.fields.m_freeRectangles,
			//           (IEnumerable_1_UnityEngine_RectInt_ *)this.fields.m_newFreeRectangles,
			//           MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::AddRange);
			//         m_newFreeRectangles = this.fields.m_newFreeRectangles;
			//         if ( m_newFreeRectangles )
			//         {
			//           ++m_newFreeRectangles.fields._version;
			//           m_newFreeRectangles.fields._size = 0;
			//           HG::Rendering::Runtime::AtlasMaxRect::_RecalculateMaxFreeRectWidthHeight(this, 0LL);
			//           return;
			//         }
			// LABEL_26:
			//         sub_180B536AC(m_newFreeRectangles, v3);
			//       }
			//       for ( j = 0; ; ++j )
			//       {
			//         v8 = this.fields.m_newFreeRectangles;
			//         if ( !v8 )
			//           goto LABEL_26;
			//         if ( j >= v8.fields._size )
			//           goto LABEL_18;
			//         System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//           (prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA *)&v16,
			//           (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_newFreeRectangles,
			//           j,
			//           MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//         v3 = (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_freeRectangles;
			//         a = v16;
			//         if ( !v3 )
			//           goto LABEL_26;
			//         System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//           (prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA *)&v17,
			//           v3,
			//           i,
			//           MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//         b = v17;
			//         if ( !HG::Rendering::Runtime::AtlasMaxRect::_IsContainedIn(this, &a, &b, 0LL) )
			//           break;
			//         v11 = (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_newFreeRectangles;
			//         v12 = j--;
			//         v3 = v11;
			//         if ( !v11 )
			//           goto LABEL_26;
			//         System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//           (prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA *)&v20,
			//           v11,
			//           v11.fields._size - 1,
			//           MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//         a = v20;
			//         System::Collections::Generic::List<Beyond::NPC::Animation::NPCCrowdLodSettingConfig::FNPCCrowdLodSetting>::set_Item(
			//           (List_1_Beyond_NPC_Animation_NPCCrowdLodSettingConfig_FNPCCrowdLodSetting_ *)v11,
			//           v12,
			//           (NPCCrowdLodSettingConfig_FNPCCrowdLodSetting *)&a,
			//           MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::set_Item);
			//         v3 = (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_newFreeRectangles;
			//         if ( !v3 )
			//           goto LABEL_26;
			//         System::Collections::Generic::List<Cinemachine::TargetPositionCache_CacheEntry::RecordingItem>::RemoveAt(
			//           (List_1_Cinemachine_TargetPositionCache_CacheEntry_RecordingItem_ *)this.fields.m_newFreeRectangles,
			//           v3.fields._size - 1,
			//           MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::RemoveAt);
			// LABEL_22:
			//         ;
			//       }
			//       v3 = (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_freeRectangles;
			//       if ( !v3 )
			//         goto LABEL_26;
			//       System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//         (prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA *)&v18,
			//         v3,
			//         i,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//       v3 = (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_newFreeRectangles;
			//       a = v18;
			//       if ( !v3 )
			//         goto LABEL_26;
			//       System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//         (prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA *)&v19,
			//         v3,
			//         j,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//       b = v19;
			//       if ( !HG::Rendering::Runtime::AtlasMaxRect::_IsContainedIn(this, &a, &b, 0LL) )
			//         goto LABEL_22;
			//       v9 = (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_freeRectangles;
			//       v10 = i--;
			//       v3 = v9;
			//       if ( !v9 )
			//         goto LABEL_26;
			//       System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//         (prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA *)&v21,
			//         v9,
			//         v9.fields._size - 1,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//       a = v21;
			//       System::Collections::Generic::List<Beyond::NPC::Animation::NPCCrowdLodSettingConfig::FNPCCrowdLodSetting>::set_Item(
			//         (List_1_Beyond_NPC_Animation_NPCCrowdLodSettingConfig_FNPCCrowdLodSetting_ *)v9,
			//         v10,
			//         (NPCCrowdLodSettingConfig_FNPCCrowdLodSetting *)&a,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::set_Item);
			//       v3 = (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_freeRectangles;
			//       if ( !v3 )
			//         goto LABEL_26;
			//       System::Collections::Generic::List<Cinemachine::TargetPositionCache_CacheEntry::RecordingItem>::RemoveAt(
			//         (List_1_Cinemachine_TargetPositionCache_CacheEntry_RecordingItem_ *)this.fields.m_freeRectangles,
			//         v3.fields._size - 1,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::RemoveAt);
			// LABEL_18:
			//       ;
			//     }
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1372, 0LL);
			//   if ( !Patch )
			//     goto LABEL_26;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private void _RecalculateMaxFreeRectWidthHeight()
		{
			// // Void _RecalculateMaxFreeRectWidthHeight()
			// void HG::Rendering::Runtime::AtlasMaxRect::_RecalculateMaxFreeRectWidthHeight(AtlasMaxRect *this, MethodInfo *method)
			// {
			//   List_1_UnityEngine_RectInt_ *v3; // rdx
			//   __int64 v4; // rcx
			//   int32_t i; // esi
			//   List_1_UnityEngine_RectInt_ *m_freeRectangles; // rax
			//   int m_maxFreeRectWidth; // ebx
			//   int m_maxFreeRectHeight; // ebx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v10; // [rsp+20h] [rbp-28h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919480 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//     byte_18D919480 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1362, 0LL) )
			//   {
			//     this.fields.m_maxFreeRectWidth = 0;
			//     this.fields.m_maxFreeRectHeight = 0;
			//     for ( i = 0; ; ++i )
			//     {
			//       m_freeRectangles = this.fields.m_freeRectangles;
			//       if ( !m_freeRectangles )
			//         break;
			//       if ( i >= m_freeRectangles.fields._size )
			//         return;
			//       m_maxFreeRectWidth = this.fields.m_maxFreeRectWidth;
			//       System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//         &v10,
			//         (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_freeRectangles,
			//         i,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//       v3 = this.fields.m_freeRectangles;
			//       if ( m_maxFreeRectWidth <= SLODWORD(v10.hdyeVnGBkdgGBgilyBhrVrxcQSQLA) )
			//         m_maxFreeRectWidth = (int)v10.hdyeVnGBkdgGBgilyBhrVrxcQSQLA;
			//       this.fields.m_maxFreeRectWidth = m_maxFreeRectWidth;
			//       m_maxFreeRectHeight = this.fields.m_maxFreeRectHeight;
			//       if ( !v3 )
			//         break;
			//       System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//         &v11,
			//         (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)v3,
			//         i,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//       if ( m_maxFreeRectHeight <= SHIDWORD(v11.hdyeVnGBkdgGBgilyBhrVrxcQSQLA) )
			//         m_maxFreeRectHeight = HIDWORD(v11.hdyeVnGBkdgGBgilyBhrVrxcQSQLA);
			//       this.fields.m_maxFreeRectHeight = m_maxFreeRectHeight;
			//     }
			// LABEL_14:
			//     sub_180B536AC(v4, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1362, 0LL);
			//   if ( !Patch )
			//     goto LABEL_14;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private void _PlaceFreeRect(in RectInt node)
		{
			// // Void _PlaceFreeRect(RectInt ByRef)
			// void HG::Rendering::Runtime::AtlasMaxRect::_PlaceFreeRect(AtlasMaxRect *this, RectInt *node, MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   List_1_UnityEngine_RectInt_ *v6; // rcx
			//   int32_t v7; // r14d
			//   List_1_UnityEngine_RectInt_ *m_freeRectangles; // rax
			//   int32_t xMin; // ebx
			//   int32_t v10; // ebx
			//   int32_t v11; // ebx
			//   int32_t v12; // ebx
			//   int32_t v13; // eax
			//   int32_t xMax; // ebx
			//   int32_t v15; // ebx
			//   int32_t v16; // ebx
			//   int32_t v17; // ebx
			//   int32_t v18; // eax
			//   int32_t yMin; // ebx
			//   int32_t v20; // ebx
			//   int32_t v21; // ebx
			//   int32_t v22; // ebx
			//   int32_t v23; // eax
			//   int32_t yMax; // ebx
			//   int32_t v25; // ebx
			//   int32_t v26; // ebx
			//   int32_t v27; // ebx
			//   int32_t v28; // eax
			//   bool IsContainedIn; // al
			//   RectInt v30; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   RectInt v32; // [rsp+20h] [rbp-50h] BYREF
			//   RectInt v33; // [rsp+30h] [rbp-40h] BYREF
			//   RectInt r; // [rsp+40h] [rbp-30h] BYREF
			//   RectInt b; // [rsp+50h] [rbp-20h] BYREF
			//   RectInt v36; // [rsp+60h] [rbp-10h] BYREF
			// 
			//   if ( !byte_18D919481 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//     byte_18D919481 = 1;
			//   }
			//   r = 0LL;
			//   b = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1357, 0LL) )
			//   {
			//     v7 = 0;
			//     r = *node;
			//     b = r;
			//     while ( 1 )
			//     {
			//       m_freeRectangles = this.fields.m_freeRectangles;
			//       if ( !m_freeRectangles )
			//         goto LABEL_38;
			//       if ( v7 >= m_freeRectangles.fields._size )
			//         break;
			//       System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//         (prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA *)&v36,
			//         (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_freeRectangles,
			//         v7,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//       v32 = *node;
			//       v33 = v36;
			//       xMin = UnityEngine::RectInt::get_xMin(&v32, 0LL);
			//       if ( xMin == UnityEngine::RectInt::get_xMax(&v33, 0LL)
			//         && (v10 = UnityEngine::RectInt::get_yMin(&v33, 0LL),
			//             v32 = *node,
			//             v10 <= UnityEngine::RectInt::get_yMin(&v32, 0LL))
			//         && (v11 = UnityEngine::RectInt::get_yMax(&v33, 0LL),
			//             v32 = *node,
			//             v11 >= UnityEngine::RectInt::get_yMax(&v32, 0LL))
			//         && (v12 = UnityEngine::RectInt::get_xMin(&v33, 0LL), v12 < UnityEngine::RectInt::get_xMin(&r, 0LL)) )
			//       {
			//         v13 = UnityEngine::RectInt::get_xMin(&v33, 0LL);
			//         UnityEngine::RectInt::set_xMin(&r, v13, 0LL);
			//       }
			//       else
			//       {
			//         v32 = *node;
			//         xMax = UnityEngine::RectInt::get_xMax(&v32, 0LL);
			//         if ( xMax == UnityEngine::RectInt::get_xMin(&v33, 0LL)
			//           && (v15 = UnityEngine::RectInt::get_yMin(&v33, 0LL),
			//               v32 = *node,
			//               v15 <= UnityEngine::RectInt::get_yMin(&v32, 0LL))
			//           && (v16 = UnityEngine::RectInt::get_yMax(&v33, 0LL),
			//               v32 = *node,
			//               v16 >= UnityEngine::RectInt::get_yMax(&v32, 0LL))
			//           && (v17 = UnityEngine::RectInt::get_xMax(&v33, 0LL), v17 > UnityEngine::RectInt::get_xMax(&r, 0LL)) )
			//         {
			//           v18 = UnityEngine::RectInt::get_xMax(&v33, 0LL);
			//           r.m_Width = v18 - r.m_XMin;
			//         }
			//         else
			//         {
			//           v32 = *node;
			//           yMin = UnityEngine::RectInt::get_yMin(&v32, 0LL);
			//           if ( yMin == UnityEngine::RectInt::get_yMax(&v33, 0LL)
			//             && (v20 = UnityEngine::RectInt::get_xMin(&v33, 0LL),
			//                 v32 = *node,
			//                 v20 <= UnityEngine::RectInt::get_xMin(&v32, 0LL))
			//             && (v21 = UnityEngine::RectInt::get_xMax(&v33, 0LL),
			//                 v32 = *node,
			//                 v21 >= UnityEngine::RectInt::get_xMax(&v32, 0LL))
			//             && (v22 = UnityEngine::RectInt::get_yMin(&v33, 0LL), v22 < UnityEngine::RectInt::get_yMin(&r, 0LL)) )
			//           {
			//             v23 = UnityEngine::RectInt::get_yMin(&v33, 0LL);
			//             UnityEngine::RectInt::set_yMin(&b, v23, 0LL);
			//           }
			//           else
			//           {
			//             v32 = *node;
			//             yMax = UnityEngine::RectInt::get_yMax(&v32, 0LL);
			//             if ( yMax == UnityEngine::RectInt::get_yMin(&v33, 0LL) )
			//             {
			//               v25 = UnityEngine::RectInt::get_xMin(&v33, 0LL);
			//               v32 = *node;
			//               if ( v25 <= UnityEngine::RectInt::get_xMin(&v32, 0LL) )
			//               {
			//                 v26 = UnityEngine::RectInt::get_xMax(&v33, 0LL);
			//                 v32 = *node;
			//                 if ( v26 >= UnityEngine::RectInt::get_xMax(&v32, 0LL) )
			//                 {
			//                   v27 = UnityEngine::RectInt::get_yMax(&v33, 0LL);
			//                   if ( v27 > UnityEngine::RectInt::get_yMax(&r, 0LL) )
			//                   {
			//                     v28 = UnityEngine::RectInt::get_yMax(&v33, 0LL);
			//                     b.m_Height = v28 - b.m_YMin;
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//       ++v7;
			//     }
			//     HG::Rendering::Runtime::AtlasMaxRect::_MergeFreeRect(this, &r, 0LL);
			//     HG::Rendering::Runtime::AtlasMaxRect::_MergeFreeRect(this, &b, 0LL);
			//     if ( !HG::Rendering::Runtime::AtlasMaxRect::_IsContainedIn(this, &r, &b, 0LL) )
			//     {
			//       IsContainedIn = HG::Rendering::Runtime::AtlasMaxRect::_IsContainedIn(this, &b, &r, 0LL);
			//       v6 = this.fields.m_freeRectangles;
			//       if ( IsContainedIn )
			//       {
			//         if ( v6 )
			//         {
			//           v30 = r;
			//           goto LABEL_34;
			//         }
			// LABEL_38:
			//         sub_180B536AC(v6, v5);
			//       }
			//       if ( !v6 )
			//         goto LABEL_38;
			//       v36 = r;
			//       sub_183320F80(v6, &v36, MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::Add);
			//     }
			//     v6 = this.fields.m_freeRectangles;
			//     if ( v6 )
			//     {
			//       v30 = b;
			// LABEL_34:
			//       v36 = v30;
			//       sub_183320F80(v6, &v36, MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::Add);
			//       return;
			//     }
			//     goto LABEL_38;
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1357, 0LL);
			//   if ( !Patch )
			//     goto LABEL_38;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_514(Patch, (Object *)this, node, 0LL);
			// }
			// 
		}

		private void _AlignRectWidth(ref RectInt src, in RectInt dst)
		{
			// // Void _AlignRectWidth(RectInt ByRef, RectInt ByRef)
			// void HG::Rendering::Runtime::AtlasMaxRect::_AlignRectWidth(
			//         AtlasMaxRect *this,
			//         RectInt *src,
			//         RectInt *dst,
			//         MethodInfo *method)
			// {
			//   int32_t xMin; // ebx
			//   int32_t v8; // eax
			//   int32_t xMax; // ebx
			//   int32_t v10; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   RectInt v14; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1360, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1360, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, v12);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_512(Patch, (Object *)this, src, dst, 0LL);
			//   }
			//   else
			//   {
			//     xMin = UnityEngine::RectInt::get_xMin(src, 0LL);
			//     v14 = *dst;
			//     v8 = UnityEngine::RectInt::get_xMin(&v14, 0LL);
			//     if ( xMin < v8 )
			//       v8 = xMin;
			//     UnityEngine::RectInt::set_xMin(src, v8, 0LL);
			//     xMax = UnityEngine::RectInt::get_xMax(src, 0LL);
			//     v14 = *dst;
			//     v10 = UnityEngine::RectInt::get_xMax(&v14, 0LL);
			//     if ( xMax > v10 )
			//       v10 = xMax;
			//     src.m_Width = v10 - src.m_XMin;
			//   }
			// }
			// 
		}

		private void _AlignRectHeight(ref RectInt src, in RectInt dst)
		{
			// // Void _AlignRectHeight(RectInt ByRef, RectInt ByRef)
			// void HG::Rendering::Runtime::AtlasMaxRect::_AlignRectHeight(
			//         AtlasMaxRect *this,
			//         RectInt *src,
			//         RectInt *dst,
			//         MethodInfo *method)
			// {
			//   int32_t yMin; // ebx
			//   int32_t v8; // eax
			//   int32_t yMax; // ebx
			//   int32_t v10; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   RectInt v14; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1361, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1361, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, v12);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_512(Patch, (Object *)this, src, dst, 0LL);
			//   }
			//   else
			//   {
			//     yMin = UnityEngine::RectInt::get_yMin(src, 0LL);
			//     v14 = *dst;
			//     v8 = UnityEngine::RectInt::get_yMin(&v14, 0LL);
			//     if ( yMin < v8 )
			//       v8 = yMin;
			//     UnityEngine::RectInt::set_yMin(src, v8, 0LL);
			//     yMax = UnityEngine::RectInt::get_yMax(src, 0LL);
			//     v14 = *dst;
			//     v10 = UnityEngine::RectInt::get_yMax(&v14, 0LL);
			//     if ( yMax > v10 )
			//       v10 = yMax;
			//     src.m_Height = v10 - src.m_YMin;
			//   }
			// }
			// 
		}

		private void _MergeFreeRect(ref RectInt r)
		{
			// // Void _MergeFreeRect(RectInt ByRef)
			// void HG::Rendering::Runtime::AtlasMaxRect::_MergeFreeRect(AtlasMaxRect *this, RectInt *r, MethodInfo *method)
			// {
			//   List_1_UnityEngine_RectInt_ *v5; // rdx
			//   List_1_UnityEngine_RectInt_ *v6; // rcx
			//   int32_t i; // r15d
			//   List_1_UnityEngine_RectInt_ *m_freeRectangles; // rax
			//   int32_t xMin; // ebx
			//   int32_t v10; // edi
			//   int32_t xMax; // ebx
			//   int32_t v12; // eax
			//   int32_t v13; // ebx
			//   int32_t v14; // edi
			//   int32_t v15; // ebx
			//   int32_t v16; // eax
			//   int32_t v17; // ebx
			//   int32_t v18; // ebx
			//   List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *v19; // rbx
			//   int32_t v20; // edi
			//   int32_t v21; // ebx
			//   int32_t v22; // ebx
			//   int32_t v23; // ebx
			//   int32_t v24; // ebx
			//   int32_t yMin; // ebx
			//   int32_t yMax; // ebx
			//   List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *v27; // rbx
			//   int32_t v28; // edi
			//   int32_t v29; // ebx
			//   int32_t v30; // ebx
			//   int32_t v31; // ebx
			//   int32_t v32; // ebx
			//   List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *v33; // rbx
			//   int32_t v34; // edi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   RectInt a; // [rsp+20h] [rbp-60h] BYREF
			//   RectInt v37; // [rsp+30h] [rbp-50h] BYREF
			//   RectInt v38; // [rsp+40h] [rbp-40h] BYREF
			//   RectInt v39; // [rsp+50h] [rbp-30h] BYREF
			//   RectInt v40; // [rsp+60h] [rbp-20h] BYREF
			//   RectInt v41; // [rsp+70h] [rbp-10h] BYREF
			// 
			//   if ( !byte_18D919482 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::RemoveAt);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::set_Item);
			//     byte_18D919482 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1358, 0LL) )
			//   {
			//     for ( i = 0; ; ++i )
			//     {
			//       m_freeRectangles = this.fields.m_freeRectangles;
			//       if ( !m_freeRectangles )
			//         goto LABEL_47;
			//       if ( i >= m_freeRectangles.fields._size )
			//         return;
			//       System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//         (prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA *)&v37,
			//         (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_freeRectangles,
			//         i,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//       a = v37;
			//       if ( HG::Rendering::Runtime::AtlasMaxRect::_IsContainedIn(this, &a, r, 0LL) )
			//       {
			//         v33 = (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_freeRectangles;
			//         v34 = i--;
			//         v5 = (List_1_UnityEngine_RectInt_ *)v33;
			//         if ( !v33 )
			//           goto LABEL_47;
			//         System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//           (prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA *)&v41,
			//           v33,
			//           v33.fields._size - 1,
			//           MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//         v39 = v41;
			//         System::Collections::Generic::List<Beyond::NPC::Animation::NPCCrowdLodSettingConfig::FNPCCrowdLodSetting>::set_Item(
			//           (List_1_Beyond_NPC_Animation_NPCCrowdLodSettingConfig_FNPCCrowdLodSetting_ *)v33,
			//           v34,
			//           (NPCCrowdLodSettingConfig_FNPCCrowdLodSetting *)&v39,
			//           MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::set_Item);
			//         v5 = this.fields.m_freeRectangles;
			//         if ( !v5 )
			//           goto LABEL_47;
			//         System::Collections::Generic::List<Cinemachine::TargetPositionCache_CacheEntry::RecordingItem>::RemoveAt(
			//           (List_1_Cinemachine_TargetPositionCache_CacheEntry_RecordingItem_ *)this.fields.m_freeRectangles,
			//           v5.fields._size - 1,
			//           MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::RemoveAt);
			//       }
			//       else
			//       {
			//         xMin = UnityEngine::RectInt::get_xMin(r, 0LL);
			//         v10 = UnityEngine::RectInt::get_xMin(&a, 0LL);
			//         if ( xMin > v10 )
			//           v10 = xMin;
			//         xMax = UnityEngine::RectInt::get_xMax(r, 0LL);
			//         v12 = UnityEngine::RectInt::get_xMax(&a, 0LL);
			//         if ( xMax < v12 )
			//           v12 = xMax;
			//         if ( v10 <= v12 )
			//         {
			//           yMin = UnityEngine::RectInt::get_yMin(&a, 0LL);
			//           if ( yMin == UnityEngine::RectInt::get_yMin(r, 0LL) )
			//           {
			//             yMax = UnityEngine::RectInt::get_yMax(&a, 0LL);
			//             if ( yMax == UnityEngine::RectInt::get_yMax(r, 0LL) )
			//             {
			//               v27 = (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_freeRectangles;
			//               v28 = i--;
			//               v5 = (List_1_UnityEngine_RectInt_ *)v27;
			//               if ( !v27 )
			//                 goto LABEL_47;
			//               System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//                 (prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA *)&v40,
			//                 v27,
			//                 v27.fields._size - 1,
			//                 MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//               v39 = v40;
			//               System::Collections::Generic::List<Beyond::NPC::Animation::NPCCrowdLodSettingConfig::FNPCCrowdLodSetting>::set_Item(
			//                 (List_1_Beyond_NPC_Animation_NPCCrowdLodSettingConfig_FNPCCrowdLodSetting_ *)v27,
			//                 v28,
			//                 (NPCCrowdLodSettingConfig_FNPCCrowdLodSetting *)&v39,
			//                 MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::set_Item);
			//               v5 = this.fields.m_freeRectangles;
			//               if ( !v5 )
			//                 goto LABEL_47;
			//               System::Collections::Generic::List<Cinemachine::TargetPositionCache_CacheEntry::RecordingItem>::RemoveAt(
			//                 (List_1_Cinemachine_TargetPositionCache_CacheEntry_RecordingItem_ *)this.fields.m_freeRectangles,
			//                 v5.fields._size - 1,
			//                 MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::RemoveAt);
			// LABEL_36:
			//               HG::Rendering::Runtime::AtlasMaxRect::_AlignRectWidth(this, r, &a, 0LL);
			//               continue;
			//             }
			//           }
			//           v29 = UnityEngine::RectInt::get_yMin(r, 0LL);
			//           if ( v29 >= UnityEngine::RectInt::get_yMin(&a, 0LL) )
			//           {
			//             v30 = UnityEngine::RectInt::get_yMax(r, 0LL);
			//             if ( v30 <= UnityEngine::RectInt::get_yMax(&a, 0LL) )
			//               goto LABEL_36;
			//           }
			//           v31 = UnityEngine::RectInt::get_yMin(&a, 0LL);
			//           if ( v31 >= UnityEngine::RectInt::get_yMin(r, 0LL) )
			//           {
			//             v32 = UnityEngine::RectInt::get_yMax(&a, 0LL);
			//             if ( v32 <= UnityEngine::RectInt::get_yMax(r, 0LL) )
			//             {
			//               HG::Rendering::Runtime::AtlasMaxRect::_AlignRectWidth(this, &a, r, 0LL);
			//               goto LABEL_29;
			//             }
			//           }
			//         }
			//         else
			//         {
			//           v13 = UnityEngine::RectInt::get_yMin(r, 0LL);
			//           v14 = UnityEngine::RectInt::get_yMin(&a, 0LL);
			//           if ( v13 > v14 )
			//             v14 = v13;
			//           v15 = UnityEngine::RectInt::get_yMax(r, 0LL);
			//           v16 = UnityEngine::RectInt::get_yMax(&a, 0LL);
			//           if ( v15 < v16 )
			//             v16 = v15;
			//           if ( v14 <= v16 )
			//           {
			//             v17 = UnityEngine::RectInt::get_xMin(&a, 0LL);
			//             if ( v17 == UnityEngine::RectInt::get_xMin(r, 0LL) )
			//             {
			//               v18 = UnityEngine::RectInt::get_xMax(&a, 0LL);
			//               if ( v18 == UnityEngine::RectInt::get_xMax(r, 0LL) )
			//               {
			//                 v19 = (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_freeRectangles;
			//                 v20 = i--;
			//                 v5 = (List_1_UnityEngine_RectInt_ *)v19;
			//                 if ( !v19 )
			//                   goto LABEL_47;
			//                 System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//                   (prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA *)&v38,
			//                   v19,
			//                   v19.fields._size - 1,
			//                   MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//                 v39 = v38;
			//                 System::Collections::Generic::List<Beyond::NPC::Animation::NPCCrowdLodSettingConfig::FNPCCrowdLodSetting>::set_Item(
			//                   (List_1_Beyond_NPC_Animation_NPCCrowdLodSettingConfig_FNPCCrowdLodSetting_ *)v19,
			//                   v20,
			//                   (NPCCrowdLodSettingConfig_FNPCCrowdLodSetting *)&v39,
			//                   MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::set_Item);
			//                 v5 = this.fields.m_freeRectangles;
			//                 if ( !v5 )
			//                   goto LABEL_47;
			//                 System::Collections::Generic::List<Cinemachine::TargetPositionCache_CacheEntry::RecordingItem>::RemoveAt(
			//                   (List_1_Cinemachine_TargetPositionCache_CacheEntry_RecordingItem_ *)this.fields.m_freeRectangles,
			//                   v5.fields._size - 1,
			//                   MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::RemoveAt);
			// LABEL_23:
			//                 HG::Rendering::Runtime::AtlasMaxRect::_AlignRectHeight(this, r, &a, 0LL);
			//                 continue;
			//               }
			//             }
			//             v21 = UnityEngine::RectInt::get_xMin(r, 0LL);
			//             if ( v21 >= UnityEngine::RectInt::get_xMin(&a, 0LL) )
			//             {
			//               v22 = UnityEngine::RectInt::get_xMax(r, 0LL);
			//               if ( v22 <= UnityEngine::RectInt::get_xMax(&a, 0LL) )
			//                 goto LABEL_23;
			//             }
			//             v23 = UnityEngine::RectInt::get_xMin(&a, 0LL);
			//             if ( v23 >= UnityEngine::RectInt::get_xMin(r, 0LL) )
			//             {
			//               v24 = UnityEngine::RectInt::get_xMax(&a, 0LL);
			//               if ( v24 <= UnityEngine::RectInt::get_xMax(r, 0LL) )
			//               {
			//                 HG::Rendering::Runtime::AtlasMaxRect::_AlignRectHeight(this, &a, r, 0LL);
			// LABEL_29:
			//                 v6 = this.fields.m_freeRectangles;
			//                 if ( !v6 )
			//                   goto LABEL_47;
			//                 v39 = a;
			//                 System::Collections::Generic::List<Beyond::NPC::Animation::NPCCrowdLodSettingConfig::FNPCCrowdLodSetting>::set_Item(
			//                   (List_1_Beyond_NPC_Animation_NPCCrowdLodSettingConfig_FNPCCrowdLodSetting_ *)v6,
			//                   i,
			//                   (NPCCrowdLodSettingConfig_FNPCCrowdLodSetting *)&v39,
			//                   MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::set_Item);
			//                 continue;
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1358, 0LL);
			//   if ( !Patch )
			// LABEL_47:
			//     sub_180B536AC(v6, v5);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_513(Patch, (Object *)this, r, 0LL);
			// }
			// 
		}

		private bool _IsContainedIn(in RectInt a, in RectInt b)
		{
			// // Boolean _IsContainedIn(RectInt ByRef, RectInt ByRef)
			// bool HG::Rendering::Runtime::AtlasMaxRect::_IsContainedIn(
			//         AtlasMaxRect *this,
			//         RectInt *a,
			//         RectInt *b,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1359, 0LL) )
			//     return (int)*(_QWORD *)&a.m_XMin >= (int)*(_QWORD *)&b.m_XMin
			//         && (int)HIDWORD(*(_QWORD *)&a.m_XMin) >= (int)HIDWORD(*(_QWORD *)&b.m_XMin)
			//         && (v7 = *(_QWORD *)&a.m_Width,
			//             (int)(v7 + *(_QWORD *)&a.m_XMin) <= (int)(*(_QWORD *)&b.m_Width + *(_QWORD *)&b.m_XMin))
			//         && (int)(HIDWORD(v7) + HIDWORD(*(_QWORD *)&a.m_XMin)) <= (int)(HIDWORD(*(_QWORD *)&b.m_XMin)
			//                                                                       + HIDWORD(*(_QWORD *)&b.m_Width));
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1359, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v11, v10);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_511(Patch, (Object *)this, a, b, 0LL);
			// }
			// 
			return default(bool);
		}

		private int _CommonIntervalCount(int i1Start, int i1End, int i2Start, int i2End)
		{
			// // Int32 _CommonIntervalCount(Int32, Int32, Int32, Int32)
			// int32_t HG::Rendering::Runtime::AtlasMaxRect::_CommonIntervalCount(
			//         AtlasMaxRect *this,
			//         int32_t i1Start,
			//         int32_t i1End,
			//         int32_t i2Start,
			//         int32_t i2End,
			//         MethodInfo *method)
			// {
			//   __int64 v11; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2282, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2282, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v11);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_823(Patch, (Object *)this, i1Start, i1End, i2Start, i2End, 0LL);
			//   }
			//   else if ( i1End < i2Start || i2End < i1Start )
			//   {
			//     return 0;
			//   }
			//   else
			//   {
			//     if ( i1Start <= i2Start )
			//       i1Start = i2Start;
			//     if ( i1End >= i2End )
			//       i1End = i2End;
			//     return i1End - i1Start;
			//   }
			// }
			// 
			return 0;
		}

		private int _ContactPointScoreNode(int x, int y, int width, int height)
		{
			// // Int32 _ContactPointScoreNode(Int32, Int32, Int32, Int32)
			// // Hidden C++ exception states: #wind=1
			// int32_t HG::Rendering::Runtime::AtlasMaxRect::_ContactPointScoreNode(
			//         AtlasMaxRect *this,
			//         int32_t x,
			//         int32_t y,
			//         int32_t width,
			//         int32_t height,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   int32_t v12; // ebx
			//   int32_t v13; // r15d
			//   __m128i v14; // xmm1
			//   unsigned __int64 v15; // xmm0_8
			//   int v16; // r8^4
			//   unsigned __int64 v17; // xmm1_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v20; // rdx
			//   __int64 v21; // rcx
			//   int32_t v22; // [rsp+40h] [rbp-A8h]
			//   Il2CppException *ex; // [rsp+48h] [rbp-A0h]
			//   Dictionary_2_TKey_TValue_Enumerator_UnityEngine_Vector2Int_Unity_Collections_NativeParallelHashSet_1_System_UInt64_ v24; // [rsp+58h] [rbp-90h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_UnityEngine_Vector2Int_Unity_Collections_NativeParallelHashSet_1_System_UInt64_ v25; // [rsp+88h] [rbp-60h] BYREF
			//   Il2CppExceptionWrapper *v26; // [rsp+B8h] [rbp-30h] BYREF
			//   __m128i v27; // [rsp+C0h] [rbp-28h]
			// 
			//   if ( !byte_18D919483 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<int,int>,UnityEngine::RectInt>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::ValueTuple<int,int>,UnityEngine::RectInt>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::ValueTuple<int,int>,UnityEngine::RectInt>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::ValueTuple<int,int>,UnityEngine::RectInt>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<System::ValueTuple<int,int>,UnityEngine::RectInt>::get_Value);
			//     byte_18D919483 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2281, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2281, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v21, v20);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_823(Patch, (Object *)this, x, y, width, height, 0LL);
			//   }
			//   else
			//   {
			//     v12 = 0;
			//     v22 = 0;
			//     if ( !x || x + width == this.fields.m_binWidth )
			//     {
			//       v13 = height;
			//       v12 = height;
			//       v22 = height;
			//     }
			//     else
			//     {
			//       v13 = height;
			//     }
			//     if ( !y || y + v13 == this.fields.m_binHeight )
			//     {
			//       v12 += width;
			//       v22 = v12;
			//     }
			//     if ( !this.fields.m_usedRectangles )
			//       sub_180B536AC(v11, v10);
			//     System::Collections::Generic::Dictionary<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::GetEnumerator(
			//       (Dictionary_2_TKey_TValue_Enumerator_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)&v25,
			//       (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)this.fields.m_usedRectangles,
			//       MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<int,int>,UnityEngine::RectInt>::GetEnumerator);
			//     v24 = v25;
			//     try
			//     {
			//       while ( 1 )
			//       {
			//         if ( !System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Vector2Int,Unity::Collections::NativeParallelHashSet<unsigned long>>::MoveNext(
			//                 &v24,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::ValueTuple<int,int>,UnityEngine::RectInt>::MoveNext) )
			//           return v12;
			//         v14 = *(__m128i *)&v24._current.key.m_X;
			//         v27 = *(__m128i *)&v24._current.key.m_X;
			//         v25._current.key = *(Vector2Int *)&v24._current.value.m_Data.m_HashMapData.m_AllocatorLabel.Index;
			//         v15 = _mm_srli_si128(*(__m128i *)&v24._current.key.m_X, 8).m128i_u64[0];
			//         if ( (_DWORD)v15 == x + width )
			//         {
			//           v16 = *((_DWORD *)&v24._current.value.m_Data.m_HashMapData.m_AllocatorLabel + 1);
			//         }
			//         else
			//         {
			//           v16 = *((_DWORD *)&v24._current.value.m_Data.m_HashMapData.m_AllocatorLabel + 1);
			//           if ( *(_DWORD *)&v24._current.value.m_Data.m_HashMapData.m_AllocatorLabel + (_DWORD)v15 != x )
			//             goto LABEL_19;
			//         }
			//         v12 += HG::Rendering::Runtime::AtlasMaxRect::_CommonIntervalCount(
			//                  this,
			//                  SHIDWORD(v15),
			//                  HIDWORD(v15) + v16,
			//                  y,
			//                  y + v13,
			//                  0LL);
			//         v22 = v12;
			//         v14 = v27;
			// LABEL_19:
			//         v17 = _mm_srli_si128(v14, 8).m128i_u64[0];
			//         if ( HIDWORD(v17) == y + v13 || HIDWORD(v17) + v25._current.key.m_Y == y )
			//         {
			//           v12 += HG::Rendering::Runtime::AtlasMaxRect::_CommonIntervalCount(
			//                    this,
			//                    v17,
			//                    v17 + v25._current.key.m_X,
			//                    x,
			//                    x + width,
			//                    0LL);
			//           v22 = v12;
			//         }
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v26 )
			//     {
			//       ex = v26.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       return v22;
			//     }
			//     return v12;
			//   }
			// }
			// 
			return 0;
		}

		private RectInt _FindPositionForNewNodeBestShortSideFit(int width, int height, out int bestShortSideFit, out int bestLongSideFit)
		{
			// // RectInt _FindPositionForNewNodeBestShortSideFit(Int32, Int32, Int32 ByRef, Int32 ByRef)
			// RectInt *HG::Rendering::Runtime::AtlasMaxRect::_FindPositionForNewNodeBestShortSideFit(
			//         RectInt *__return_ptr retstr,
			//         AtlasMaxRect *this,
			//         int32_t width,
			//         int32_t height,
			//         int32_t *bestShortSideFit,
			//         int32_t *bestLongSideFit,
			//         MethodInfo *method)
			// {
			//   int v7; // esi
			//   List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *Patch; // rdx
			//   __int64 v12; // rcx
			//   RectInt v13; // xmm6
			//   int32_t v14; // ebx
			//   List_1_UnityEngine_RectInt_ *m_freeRectangles; // rax
			//   int32_t v16; // eax
			//   int32_t v17; // r14d
			//   int32_t v18; // eax
			//   int32_t v19; // esi
			//   __m128i v21; // [rsp+48h] [rbp-61h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v22; // [rsp+58h] [rbp-51h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v23; // [rsp+68h] [rbp-41h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v24; // [rsp+78h] [rbp-31h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v25; // [rsp+88h] [rbp-21h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v26; // [rsp+98h] [rbp-11h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v27; // [rsp+A8h] [rbp-1h] BYREF
			// 
			//   v7 = height;
			//   if ( !byte_18D919484 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//     byte_18D919484 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2278, 0LL) )
			//   {
			//     v12 = 0x7FFFFFFFLL;
			//     v13 = 0LL;
			//     v21 = 0LL;
			//     v14 = 0;
			//     *bestShortSideFit = 0x7FFFFFFF;
			//     *bestLongSideFit = 0x7FFFFFFF;
			//     while ( 1 )
			//     {
			//       m_freeRectangles = this.fields.m_freeRectangles;
			//       if ( !m_freeRectangles )
			//         goto LABEL_26;
			//       if ( v14 >= m_freeRectangles.fields._size )
			//       {
			//         *retstr = v13;
			//         return retstr;
			//       }
			//       System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//         &v22,
			//         (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_freeRectangles,
			//         v14,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//       if ( SLODWORD(v22.hdyeVnGBkdgGBgilyBhrVrxcQSQLA) >= width )
			//       {
			//         Patch = (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_freeRectangles;
			//         if ( !Patch )
			//           goto LABEL_26;
			//         System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//           &v23,
			//           Patch,
			//           v14,
			//           MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//         if ( SHIDWORD(v23.hdyeVnGBkdgGBgilyBhrVrxcQSQLA) >= v7 )
			//           break;
			//       }
			// LABEL_23:
			//       ++v14;
			//     }
			//     Patch = (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_freeRectangles;
			//     if ( !Patch )
			//       goto LABEL_26;
			//     System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//       &v24,
			//       Patch,
			//       v14,
			//       MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//     v16 = sub_1824AD5C0((unsigned int)(LODWORD(v24.hdyeVnGBkdgGBgilyBhrVrxcQSQLA) - width));
			//     Patch = (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_freeRectangles;
			//     v17 = v16;
			//     if ( !Patch )
			//       goto LABEL_26;
			//     System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//       &v25,
			//       Patch,
			//       v14,
			//       MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//     v18 = sub_1824AD5C0((unsigned int)(HIDWORD(v25.hdyeVnGBkdgGBgilyBhrVrxcQSQLA) - v7));
			//     if ( v17 >= v18 )
			//     {
			//       v19 = v18;
			//       if ( v17 > v18 )
			//         goto LABEL_16;
			//     }
			//     else
			//     {
			//       v19 = v17;
			//     }
			//     v17 = v18;
			// LABEL_16:
			//     if ( v19 < *bestShortSideFit || v19 == *bestShortSideFit && v17 < *bestLongSideFit )
			//     {
			//       Patch = (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_freeRectangles;
			//       if ( !Patch )
			//         goto LABEL_26;
			//       System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//         &v26,
			//         Patch,
			//         v14,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//       Patch = (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_freeRectangles;
			//       v21.m128i_i32[0] = v26.EEjhUIhIcsWLXXeGfefLxEjqKdgQ;
			//       if ( !Patch )
			//         goto LABEL_26;
			//       System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//         &v27,
			//         Patch,
			//         v14,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//       v21.m128i_i32[1] = v27.DoaPxMFAmfwLwshNWtiPzjXtBZNn;
			//       v21.m128i_i64[1] = __PAIR64__(height, width);
			//       v13 = (RectInt)_mm_loadu_si128(&v21);
			//       *bestShortSideFit = v19;
			//       *bestLongSideFit = v17;
			//     }
			//     v7 = height;
			//     goto LABEL_23;
			//   }
			//   Patch = (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)IFix::WrappersManagerImpl::GetPatch(
			//                                                                                   2278,
			//                                                                                   0LL);
			//   if ( !Patch )
			// LABEL_26:
			//     sub_180B536AC(v12, Patch);
			//   *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_822(
			//                (RectInt *)&v27,
			//                (ILFixDynamicMethodWrapper_2 *)Patch,
			//                (Object *)this,
			//                width,
			//                v7,
			//                bestShortSideFit,
			//                bestLongSideFit,
			//                0LL);
			//   return retstr;
			// }
			// 
			return null;
		}

		private RectInt _FindPositionForNewNodeBottomLeft(int width, int height, out int bestY, out int bestX)
		{
			// // RectInt _FindPositionForNewNodeBottomLeft(Int32, Int32, Int32 ByRef, Int32 ByRef)
			// RectInt *HG::Rendering::Runtime::AtlasMaxRect::_FindPositionForNewNodeBottomLeft(
			//         RectInt *__return_ptr retstr,
			//         AtlasMaxRect *this,
			//         int32_t width,
			//         int32_t height,
			//         int32_t *bestY,
			//         int32_t *bestX,
			//         MethodInfo *method)
			// {
			//   int v8; // esi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v12; // rcx
			//   RectInt v13; // xmm6
			//   int32_t v14; // ebx
			//   List_1_UnityEngine_RectInt_ *m_freeRectangles; // rax
			//   int32_t v16; // esi
			//   __int64 v17; // rax
			//   __m128i v19; // [rsp+48h] [rbp-71h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v20; // [rsp+58h] [rbp-61h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v21; // [rsp+68h] [rbp-51h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v22; // [rsp+78h] [rbp-41h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v23; // [rsp+88h] [rbp-31h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v24; // [rsp+98h] [rbp-21h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v25; // [rsp+A8h] [rbp-11h] BYREF
			//   RectInt v26[2]; // [rsp+B8h] [rbp-1h] BYREF
			// 
			//   v8 = width;
			//   if ( !byte_18D919485 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//     byte_18D919485 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2289, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2289, 0LL);
			//     if ( !Patch )
			// LABEL_23:
			//       sub_180B536AC(v12, Patch);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_822(
			//                  v26,
			//                  Patch,
			//                  (Object *)this,
			//                  v8,
			//                  height,
			//                  bestY,
			//                  bestX,
			//                  0LL);
			//   }
			//   else
			//   {
			//     v13 = 0LL;
			//     v19 = 0LL;
			//     v14 = 0;
			//     *bestY = 0x7FFFFFFF;
			//     *bestX = 0x7FFFFFFF;
			//     while ( 1 )
			//     {
			//       m_freeRectangles = this.fields.m_freeRectangles;
			//       if ( !m_freeRectangles )
			//         goto LABEL_23;
			//       if ( v14 >= m_freeRectangles.fields._size )
			//         break;
			//       System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//         &v20,
			//         (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_freeRectangles,
			//         v14,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//       if ( SLODWORD(v20.hdyeVnGBkdgGBgilyBhrVrxcQSQLA) >= v8 )
			//       {
			//         Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_freeRectangles;
			//         if ( !Patch )
			//           goto LABEL_23;
			//         System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//           &v21,
			//           (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)Patch,
			//           v14,
			//           MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//         if ( SHIDWORD(v21.hdyeVnGBkdgGBgilyBhrVrxcQSQLA) >= height )
			//         {
			//           Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_freeRectangles;
			//           if ( !Patch )
			//             goto LABEL_23;
			//           System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//             &v22,
			//             (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)Patch,
			//             v14,
			//             MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//           v16 = height + v22.DoaPxMFAmfwLwshNWtiPzjXtBZNn;
			//           if ( (signed int)(height + v22.DoaPxMFAmfwLwshNWtiPzjXtBZNn) < *bestY )
			//             goto LABEL_15;
			//           if ( v16 == *bestY )
			//           {
			//             Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_freeRectangles;
			//             if ( !Patch )
			//               goto LABEL_23;
			//             System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//               &v23,
			//               (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)Patch,
			//               v14,
			//               MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//             if ( v23.EEjhUIhIcsWLXXeGfefLxEjqKdgQ < *bestX )
			//             {
			// LABEL_15:
			//               Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_freeRectangles;
			//               if ( !Patch )
			//                 goto LABEL_23;
			//               System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//                 &v24,
			//                 (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)Patch,
			//                 v14,
			//                 MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//               Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_freeRectangles;
			//               v19.m128i_i32[0] = v24.EEjhUIhIcsWLXXeGfefLxEjqKdgQ;
			//               if ( !Patch )
			//                 goto LABEL_23;
			//               System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//                 &v25,
			//                 (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)Patch,
			//                 v14,
			//                 MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//               v17 = HIDWORD(*(_QWORD *)&v25.EEjhUIhIcsWLXXeGfefLxEjqKdgQ);
			//               *bestY = v16;
			//               Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_freeRectangles;
			//               *(__int64 *)((char *)v19.m128i_i64 + 4) = __PAIR64__(width, v17);
			//               v19.m128i_i32[3] = height;
			//               if ( !Patch )
			//                 goto LABEL_23;
			//               System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//                 (prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA *)v26,
			//                 (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)Patch,
			//                 v14,
			//                 MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//               v13 = (RectInt)_mm_loadu_si128(&v19);
			//               *bestX = v26[0].m_XMin;
			//             }
			//           }
			//           v8 = width;
			//         }
			//       }
			//       ++v14;
			//     }
			//     *retstr = v13;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		private RectInt _FindPositionForNewNodeContactPoint(int width, int height, out int bestContactScore)
		{
			// // RectInt _FindPositionForNewNodeContactPoint(Int32, Int32, Int32 ByRef)
			// RectInt *HG::Rendering::Runtime::AtlasMaxRect::_FindPositionForNewNodeContactPoint(
			//         RectInt *__return_ptr retstr,
			//         AtlasMaxRect *this,
			//         int32_t width,
			//         int32_t height,
			//         int32_t *bestContactScore,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 EEjhUIhIcsWLXXeGfefLxEjqKdgQ; // rcx
			//   RectInt v12; // xmm6
			//   int32_t i; // edi
			//   List_1_UnityEngine_RectInt_ *m_freeRectangles; // rax
			//   int32_t v15; // r13d
			//   __m128i v17; // [rsp+48h] [rbp-59h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v18; // [rsp+58h] [rbp-49h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v19; // [rsp+68h] [rbp-39h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v20; // [rsp+78h] [rbp-29h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA x; // [rsp+88h] [rbp-19h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v22; // [rsp+98h] [rbp-9h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v23; // [rsp+A8h] [rbp+7h] BYREF
			// 
			//   if ( !byte_18D919486 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//     byte_18D919486 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2280, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2280, 0LL);
			//     if ( !Patch )
			// LABEL_19:
			//       sub_180B536AC(EEjhUIhIcsWLXXeGfefLxEjqKdgQ, Patch);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_824(
			//                  (RectInt *)&v23,
			//                  Patch,
			//                  (Object *)this,
			//                  width,
			//                  height,
			//                  bestContactScore,
			//                  0LL);
			//   }
			//   else
			//   {
			//     v12 = 0LL;
			//     v17 = 0LL;
			//     *bestContactScore = -1;
			//     for ( i = 0; ; ++i )
			//     {
			//       m_freeRectangles = this.fields.m_freeRectangles;
			//       if ( !m_freeRectangles )
			//         goto LABEL_19;
			//       if ( i >= m_freeRectangles.fields._size )
			//         break;
			//       System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//         &v18,
			//         (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_freeRectangles,
			//         i,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//       if ( SLODWORD(v18.hdyeVnGBkdgGBgilyBhrVrxcQSQLA) >= width )
			//       {
			//         Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_freeRectangles;
			//         if ( !Patch )
			//           goto LABEL_19;
			//         System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//           &v19,
			//           (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)Patch,
			//           i,
			//           MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//         if ( SHIDWORD(v19.hdyeVnGBkdgGBgilyBhrVrxcQSQLA) >= height )
			//         {
			//           Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_freeRectangles;
			//           if ( !Patch )
			//             goto LABEL_19;
			//           System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//             &x,
			//             (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)Patch,
			//             i,
			//             MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//           Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_freeRectangles;
			//           if ( !Patch )
			//             goto LABEL_19;
			//           System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//             &v20,
			//             (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)Patch,
			//             i,
			//             MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//           v15 = HG::Rendering::Runtime::AtlasMaxRect::_ContactPointScoreNode(
			//                   this,
			//                   x.EEjhUIhIcsWLXXeGfefLxEjqKdgQ,
			//                   v20.DoaPxMFAmfwLwshNWtiPzjXtBZNn,
			//                   width,
			//                   height,
			//                   0LL);
			//           if ( v15 > *bestContactScore )
			//           {
			//             Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_freeRectangles;
			//             if ( !Patch )
			//               goto LABEL_19;
			//             System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//               &v22,
			//               (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)Patch,
			//               i,
			//               MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//             Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_freeRectangles;
			//             EEjhUIhIcsWLXXeGfefLxEjqKdgQ = (unsigned int)v22.EEjhUIhIcsWLXXeGfefLxEjqKdgQ;
			//             v17.m128i_i32[0] = v22.EEjhUIhIcsWLXXeGfefLxEjqKdgQ;
			//             if ( !Patch )
			//               goto LABEL_19;
			//             System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//               &v23,
			//               (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)Patch,
			//               i,
			//               MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//             *(__int64 *)((char *)v17.m128i_i64 + 4) = __PAIR64__(width, v23.DoaPxMFAmfwLwshNWtiPzjXtBZNn);
			//             v17.m128i_i32[3] = height;
			//             v12 = (RectInt)_mm_loadu_si128(&v17);
			//             *bestContactScore = v15;
			//           }
			//         }
			//       }
			//     }
			//     *retstr = v12;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		private RectInt _FindPositionForNewNodeBestLongSideFit(int width, int height, out int bestShortSideFit, out int bestLongSideFit)
		{
			// // RectInt _FindPositionForNewNodeBestLongSideFit(Int32, Int32, Int32 ByRef, Int32 ByRef)
			// RectInt *HG::Rendering::Runtime::AtlasMaxRect::_FindPositionForNewNodeBestLongSideFit(
			//         RectInt *__return_ptr retstr,
			//         AtlasMaxRect *this,
			//         int32_t width,
			//         int32_t height,
			//         int32_t *bestShortSideFit,
			//         int32_t *bestLongSideFit,
			//         MethodInfo *method)
			// {
			//   int v7; // r14d
			//   List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *Patch; // rdx
			//   __int64 v12; // rcx
			//   RectInt v13; // xmm6
			//   int32_t v14; // ebx
			//   List_1_UnityEngine_RectInt_ *m_freeRectangles; // rax
			//   int32_t v16; // eax
			//   int32_t v17; // esi
			//   int32_t v18; // eax
			//   int32_t v19; // r14d
			//   __m128i v21; // [rsp+48h] [rbp-61h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v22; // [rsp+58h] [rbp-51h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v23; // [rsp+68h] [rbp-41h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v24; // [rsp+78h] [rbp-31h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v25; // [rsp+88h] [rbp-21h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v26; // [rsp+98h] [rbp-11h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v27; // [rsp+A8h] [rbp-1h] BYREF
			// 
			//   v7 = height;
			//   if ( !byte_18D919487 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//     byte_18D919487 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2284, 0LL) )
			//   {
			//     v12 = 0x7FFFFFFFLL;
			//     v13 = 0LL;
			//     v21 = 0LL;
			//     v14 = 0;
			//     *bestShortSideFit = 0x7FFFFFFF;
			//     *bestLongSideFit = 0x7FFFFFFF;
			//     while ( 1 )
			//     {
			//       m_freeRectangles = this.fields.m_freeRectangles;
			//       if ( !m_freeRectangles )
			//         goto LABEL_26;
			//       if ( v14 >= m_freeRectangles.fields._size )
			//       {
			//         *retstr = v13;
			//         return retstr;
			//       }
			//       System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//         &v22,
			//         (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_freeRectangles,
			//         v14,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//       if ( SLODWORD(v22.hdyeVnGBkdgGBgilyBhrVrxcQSQLA) >= width )
			//       {
			//         Patch = (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_freeRectangles;
			//         if ( !Patch )
			//           goto LABEL_26;
			//         System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//           &v23,
			//           Patch,
			//           v14,
			//           MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//         if ( SHIDWORD(v23.hdyeVnGBkdgGBgilyBhrVrxcQSQLA) >= v7 )
			//           break;
			//       }
			// LABEL_23:
			//       ++v14;
			//     }
			//     Patch = (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_freeRectangles;
			//     if ( !Patch )
			//       goto LABEL_26;
			//     System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//       &v24,
			//       Patch,
			//       v14,
			//       MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//     v16 = sub_1824AD5C0((unsigned int)(LODWORD(v24.hdyeVnGBkdgGBgilyBhrVrxcQSQLA) - width));
			//     Patch = (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_freeRectangles;
			//     v17 = v16;
			//     if ( !Patch )
			//       goto LABEL_26;
			//     System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//       &v25,
			//       Patch,
			//       v14,
			//       MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//     v18 = sub_1824AD5C0((unsigned int)(HIDWORD(v25.hdyeVnGBkdgGBgilyBhrVrxcQSQLA) - v7));
			//     if ( v17 >= v18 )
			//     {
			//       v19 = v18;
			//       if ( v17 > v18 )
			//         goto LABEL_16;
			//     }
			//     else
			//     {
			//       v19 = v17;
			//     }
			//     v17 = v18;
			// LABEL_16:
			//     if ( v17 < *bestLongSideFit || v17 == *bestLongSideFit && v19 < *bestShortSideFit )
			//     {
			//       Patch = (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_freeRectangles;
			//       if ( !Patch )
			//         goto LABEL_26;
			//       System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//         &v26,
			//         Patch,
			//         v14,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//       Patch = (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_freeRectangles;
			//       v21.m128i_i32[0] = v26.EEjhUIhIcsWLXXeGfefLxEjqKdgQ;
			//       if ( !Patch )
			//         goto LABEL_26;
			//       System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//         &v27,
			//         Patch,
			//         v14,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//       v21.m128i_i32[1] = v27.DoaPxMFAmfwLwshNWtiPzjXtBZNn;
			//       v21.m128i_i64[1] = __PAIR64__(height, width);
			//       v13 = (RectInt)_mm_loadu_si128(&v21);
			//       *bestShortSideFit = v19;
			//       *bestLongSideFit = v17;
			//     }
			//     v7 = height;
			//     goto LABEL_23;
			//   }
			//   Patch = (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)IFix::WrappersManagerImpl::GetPatch(
			//                                                                                   2284,
			//                                                                                   0LL);
			//   if ( !Patch )
			// LABEL_26:
			//     sub_180B536AC(v12, Patch);
			//   *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_822(
			//                (RectInt *)&v27,
			//                (ILFixDynamicMethodWrapper_2 *)Patch,
			//                (Object *)this,
			//                width,
			//                v7,
			//                bestShortSideFit,
			//                bestLongSideFit,
			//                0LL);
			//   return retstr;
			// }
			// 
			return null;
		}

		private RectInt _FindPositionForNewNodeBestAreaFit(int width, int height, out int bestAreaFit, out int bestShortSideFit)
		{
			// // RectInt _FindPositionForNewNodeBestAreaFit(Int32, Int32, Int32 ByRef, Int32 ByRef)
			// RectInt *HG::Rendering::Runtime::AtlasMaxRect::_FindPositionForNewNodeBestAreaFit(
			//         RectInt *__return_ptr retstr,
			//         AtlasMaxRect *this,
			//         int32_t width,
			//         int32_t height,
			//         int32_t *bestAreaFit,
			//         int32_t *bestShortSideFit,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v12; // rcx
			//   RectInt v13; // xmm6
			//   int32_t v14; // ebx
			//   List_1_UnityEngine_RectInt_ *m_freeRectangles; // rax
			//   int v16; // esi
			//   int32_t v17; // eax
			//   int32_t v18; // eax
			//   __m128i v20; // [rsp+48h] [rbp-81h] BYREF
			//   RectInt v21; // [rsp+58h] [rbp-71h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v22; // [rsp+68h] [rbp-61h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v23; // [rsp+78h] [rbp-51h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v24; // [rsp+88h] [rbp-41h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v25; // [rsp+98h] [rbp-31h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v26; // [rsp+A8h] [rbp-21h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v27; // [rsp+B8h] [rbp-11h] BYREF
			//   prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA v28; // [rsp+C8h] [rbp-1h] BYREF
			//   int32_t v29; // [rsp+118h] [rbp+4Fh]
			//   int32_t v30; // [rsp+118h] [rbp+4Fh]
			// 
			//   if ( !byte_18D919488 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//     byte_18D919488 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2286, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2286, 0LL);
			//     if ( !Patch )
			// LABEL_25:
			//       sub_180B536AC(v12, Patch);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_822(
			//                  &v21,
			//                  Patch,
			//                  (Object *)this,
			//                  width,
			//                  height,
			//                  bestAreaFit,
			//                  bestShortSideFit,
			//                  0LL);
			//   }
			//   else
			//   {
			//     v12 = 0x7FFFFFFFLL;
			//     v13 = 0LL;
			//     v20 = 0LL;
			//     v14 = 0;
			//     *bestAreaFit = 0x7FFFFFFF;
			//     *bestShortSideFit = 0x7FFFFFFF;
			//     while ( 1 )
			//     {
			//       m_freeRectangles = this.fields.m_freeRectangles;
			//       if ( !m_freeRectangles )
			//         goto LABEL_25;
			//       if ( v14 >= m_freeRectangles.fields._size )
			//         break;
			//       System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//         &v23,
			//         (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)this.fields.m_freeRectangles,
			//         v14,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//       Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_freeRectangles;
			//       if ( !Patch )
			//         goto LABEL_25;
			//       System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//         &v22,
			//         (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)Patch,
			//         v14,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//       Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_freeRectangles;
			//       v16 = LODWORD(v23.hdyeVnGBkdgGBgilyBhrVrxcQSQLA) * HIDWORD(v22.hdyeVnGBkdgGBgilyBhrVrxcQSQLA) - height * width;
			//       if ( !Patch )
			//         goto LABEL_25;
			//       System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//         &v24,
			//         (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)Patch,
			//         v14,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//       if ( SLODWORD(v24.hdyeVnGBkdgGBgilyBhrVrxcQSQLA) >= width )
			//       {
			//         Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_freeRectangles;
			//         if ( !Patch )
			//           goto LABEL_25;
			//         System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//           &v25,
			//           (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)Patch,
			//           v14,
			//           MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//         if ( SHIDWORD(v25.hdyeVnGBkdgGBgilyBhrVrxcQSQLA) >= height )
			//         {
			//           Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_freeRectangles;
			//           if ( !Patch )
			//             goto LABEL_25;
			//           System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//             &v26,
			//             (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)Patch,
			//             v14,
			//             MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//           v17 = sub_1824AD5C0((unsigned int)(LODWORD(v26.hdyeVnGBkdgGBgilyBhrVrxcQSQLA) - width));
			//           Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_freeRectangles;
			//           v29 = v17;
			//           if ( !Patch )
			//             goto LABEL_25;
			//           System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//             &v27,
			//             (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)Patch,
			//             v14,
			//             MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//           v18 = sub_1824AD5C0((unsigned int)(HIDWORD(v27.hdyeVnGBkdgGBgilyBhrVrxcQSQLA) - height));
			//           if ( v29 < v18 )
			//             v18 = v29;
			//           v30 = v18;
			//           if ( v16 < *bestAreaFit || v16 == *bestAreaFit && (v12 = (__int64)bestShortSideFit, v18 < *bestShortSideFit) )
			//           {
			//             Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_freeRectangles;
			//             if ( !Patch )
			//               goto LABEL_25;
			//             System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//               &v28,
			//               (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)Patch,
			//               v14,
			//               MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//             Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_freeRectangles;
			//             v20.m128i_i32[0] = v28.EEjhUIhIcsWLXXeGfefLxEjqKdgQ;
			//             if ( !Patch )
			//               goto LABEL_25;
			//             System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::cQuuLrgeChfSTCfVgQjFhkvLyfEuA>::get_Item(
			//               (prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA *)&v21,
			//               (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_cQuuLrgeChfSTCfVgQjFhkvLyfEuA_ *)Patch,
			//               v14,
			//               MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
			//             v12 = (__int64)bestShortSideFit;
			//             *(__int64 *)((char *)v20.m128i_i64 + 4) = __PAIR64__(width, v21.m_YMin);
			//             v20.m128i_i32[3] = height;
			//             v13 = (RectInt)_mm_loadu_si128(&v20);
			//             *bestShortSideFit = v30;
			//             *bestAreaFit = v16;
			//           }
			//         }
			//       }
			//       ++v14;
			//     }
			//     *retstr = v13;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		private readonly int m_binWidth;

		private readonly int m_binHeight;

		private readonly List<RectInt> m_newFreeRectangles;

		private readonly List<RectInt> m_freeRectangles;

		private readonly Dictionary<ValueTuple<int, int>, RectInt> m_usedRectangles;

		private int m_usedRectSize;

		private int m_maxFreeRectWidth;

		private int m_maxFreeRectHeight;

		public enum FreeRectChoiceHeuristic
		{
			RectBestShortSideFit,
			RectBestLongSideFit,
			RectBestAreaFit,
			RectBottomLeftRule,
			RectContactPointRule
		}
	}
}
