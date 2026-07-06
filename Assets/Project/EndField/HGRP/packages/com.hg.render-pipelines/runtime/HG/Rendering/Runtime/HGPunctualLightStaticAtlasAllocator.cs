using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	internal class HGPunctualLightStaticAtlasAllocator
	{
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x00002608 File Offset: 0x00000808
		public int SlotCount
		{
			get
			{
				// // Int32 get_Length()
				// int32_t System::Dynamic::ExpandoObject::ExpandoData::get_Length(ExpandoObject_ExpandoData *this, MethodInfo *method)
				// {
				//   Object__Array *dataArray; // rax
				// 
				//   dataArray = this.fields._dataArray;
				//   if ( !dataArray )
				//     sub_180B536AC(this, method);
				//   return dataArray.max_length.size;
				// }
				// 
				return 0;
			}
		}

		public HGPunctualLightStaticAtlasAllocator(int levelCount, int atlasResolution)
		{
		}

		public int TryAlloc(int level)
		{
			// // Int32 TryAlloc(Int32)
			// int32_t HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::TryAlloc(
			//         HGPunctualLightStaticAtlasAllocator *this,
			//         int32_t level,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // r8
			//   __int64 v6; // rdx
			//   Boolean__Array *m_slotOccupied; // rcx
			//   int32_t v8; // r8d
			//   int32_t result; // eax
			//   Object *v10; // rax
			//   String *v11; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   int32_t v13; // [rsp+48h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919E95 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Int32);
			//     sub_18003C530(&off_18D5F31B0);
			//     byte_18D919E95 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1646, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1646, 0LL);
			//     if ( !Patch )
			// LABEL_19:
			//       sub_180B536AC(m_slotOccupied, v6);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_47(
			//              (ILFixDynamicMethodWrapper_20 *)Patch,
			//              (Object *)this,
			//              level,
			//              0LL);
			//   }
			//   else if ( level < 0 || level >= this.fields.m_levelCount )
			//   {
			//     v13 = level;
			//     v10 = (Object *)il2cpp_value_box_0(TypeInfo::System::Int32, &v13, v5);
			//     v11 = System::String::Format((String *)"HGPunctualLightAtlasAllocator: Invalid level {0} requested", v10, 0LL);
			//     HG::Rendering::HGRPLogger::LogError(v11, 0LL);
			//     return -1;
			//   }
			//   else
			//   {
			//     v6 = 16LL;
			//     if ( level != this.fields.m_levelCount - 1 )
			//       v6 = 12LL;
			//     m_slotOccupied = this.fields.m_slotOccupied;
			//     v8 = 12 * level;
			//     while ( 1 )
			//     {
			//       if ( !m_slotOccupied )
			//         goto LABEL_19;
			//       if ( (unsigned int)v8 >= m_slotOccupied.max_length.size )
			//         sub_180070270(m_slotOccupied, v6);
			//       if ( !m_slotOccupied.vector[v8] )
			//         break;
			//       ++v8;
			//       if ( -12 * level + v8 >= (int)v6 )
			//         return -1;
			//     }
			//     result = v8;
			//     this.fields.m_slotOccupied.vector[v8] = 1;
			//   }
			//   return result;
			// }
			// 
			return 0;
		}

		public bool Free(int slotIndex)
		{
			// // Boolean Free(Int32)
			// bool HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::Free(
			//         HGPunctualLightStaticAtlasAllocator *this,
			//         int32_t slotIndex,
			//         MethodInfo *method)
			// {
			//   __int64 v4; // rbx
			//   __int64 v5; // rdx
			//   __int64 v6; // r8
			//   Boolean__Array *m_slotOccupied; // rcx
			//   Object *v8; // rax
			//   String *v9; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   int v12; // [rsp+48h] [rbp+20h] BYREF
			// 
			//   v4 = slotIndex;
			//   if ( !byte_18D919E96 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Int32);
			//     sub_18003C530(&off_18D5F3188);
			//     byte_18D919E96 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1642, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1642, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
			//                (ILFixDynamicMethodWrapper_13 *)Patch,
			//                (Object *)this,
			//                (NaviDirection__Enum)v4,
			//                0LL);
			// LABEL_12:
			//     sub_180B536AC(m_slotOccupied, v5);
			//   }
			//   m_slotOccupied = this.fields.m_slotOccupied;
			//   if ( !m_slotOccupied )
			//     goto LABEL_12;
			//   if ( (unsigned int)v4 >= m_slotOccupied.max_length.size )
			//     goto LABEL_10;
			//   if ( !m_slotOccupied.vector[v4] )
			//   {
			//     v12 = v4;
			//     v8 = (Object *)il2cpp_value_box_0(TypeInfo::System::Int32, &v12, v6);
			//     v9 = System::String::Format(
			//            (String *)"HGPunctualLightAtlasAllocator: Slot {0} is already empty, failed to release!",
			//            v8,
			//            0LL);
			//     HG::Rendering::HGRPLogger::LogWarning(v9, 0LL);
			//     return 0;
			//   }
			//   if ( (unsigned int)v4 >= m_slotOccupied.max_length.size )
			// LABEL_10:
			//     sub_180070270(m_slotOccupied, v5);
			//   m_slotOccupied.vector[v4] = 0;
			//   return 1;
			// }
			// 
			return default(bool);
		}

		public void FreeAll()
		{
			// // Void FreeAll()
			// void HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::FreeAll(
			//         HGPunctualLightStaticAtlasAllocator *this,
			//         MethodInfo *method)
			// {
			//   Boolean__Array *v3; // rcx
			//   __int64 v4; // rdx
			//   Boolean__Array *m_slotOccupied; // rax
			//   __int64 v6; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1634, 0LL) )
			//   {
			//     v4 = 0LL;
			//     while ( 1 )
			//     {
			//       m_slotOccupied = this.fields.m_slotOccupied;
			//       if ( !m_slotOccupied )
			//         break;
			//       if ( (int)v4 >= m_slotOccupied.max_length.size )
			//         return;
			//       v3 = this.fields.m_slotOccupied;
			//       if ( (unsigned int)v4 >= m_slotOccupied.max_length.size )
			//         sub_180070270(v3, v4);
			//       v6 = (int)v4;
			//       v4 = (unsigned int)(v4 + 1);
			//       v3.vector[v6] = 0;
			//     }
			// LABEL_9:
			//     sub_180B536AC(v3, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1634, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public int GetSlotLevelFromIndex(int slotIndex)
		{
			// // Int32 GetSlotLevelFromIndex(Int32)
			// int32_t HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::GetSlotLevelFromIndex(
			//         HGPunctualLightStaticAtlasAllocator *this,
			//         int32_t slotIndex,
			//         MethodInfo *method)
			// {
			//   int32_t m_levelCount; // ebx
			//   int32_t v6; // ebx
			//   int32_t v7; // edx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			// 
			//   if ( !byte_18D919E97 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Math);
			//     byte_18D919E97 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1644, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1644, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_47(
			//              (ILFixDynamicMethodWrapper_20 *)Patch,
			//              (Object *)this,
			//              slotIndex,
			//              0LL);
			//   }
			//   else
			//   {
			//     m_levelCount = this.fields.m_levelCount;
			//     sub_180002C70(TypeInfo::System::Math);
			//     v6 = m_levelCount - 1;
			//     v7 = slotIndex / 12;
			//     if ( slotIndex / 12 > v6 )
			//       return v6;
			//     return v7;
			//   }
			// }
			// 
			return 0;
		}

		public RectInt GetRectFromSlotIndex(int slotIndex)
		{
			// // RectInt GetRectFromSlotIndex(Int32)
			// RectInt *HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::GetRectFromSlotIndex(
			//         RectInt *__return_ptr retstr,
			//         HGPunctualLightStaticAtlasAllocator *this,
			//         int32_t slotIndex,
			//         MethodInfo *method)
			// {
			//   int32_t m_levelCount; // ebx
			//   int v8; // ebx
			//   int32_t v9; // edx
			//   RectInt *RectFromLevelIndex; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   RectInt v14; // xmm0
			//   RectInt *result; // rax
			//   RectInt v16; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919E98 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Math);
			//     byte_18D919E98 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1843, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1843, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, v12);
			//     RectFromLevelIndex = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_711(&v16, Patch, (Object *)this, slotIndex, 0LL);
			//   }
			//   else
			//   {
			//     m_levelCount = this.fields.m_levelCount;
			//     sub_180002C70(TypeInfo::System::Math);
			//     v8 = m_levelCount - 1;
			//     v9 = slotIndex / 12;
			//     if ( slotIndex / 12 > v8 )
			//       v9 = v8;
			//     RectFromLevelIndex = HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::GetRectFromLevelIndex(
			//                            &v16,
			//                            this,
			//                            v9,
			//                            slotIndex - 12 * v9,
			//                            0LL);
			//   }
			//   v14 = *RectFromLevelIndex;
			//   result = retstr;
			//   *retstr = v14;
			//   return result;
			// }
			// 
			return null;
		}

		public RectInt GetRectFromLevelIndex(int level, int levelIndex)
		{
			// // RectInt GetRectFromLevelIndex(Int32, Int32)
			// RectInt *HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::GetRectFromLevelIndex(
			//         RectInt *__return_ptr retstr,
			//         HGPunctualLightStaticAtlasAllocator *this,
			//         int32_t level,
			//         int32_t levelIndex,
			//         MethodInfo *method)
			// {
			//   __int64 v6; // rbp
			//   int v9; // edi
			//   int32_t v10; // esi
			//   int v11; // r15d
			//   __int64 v12; // rdx
			//   Vector2Int__Array *RECT_OFFSETS; // rcx
			//   int v14; // edi
			//   int v15; // ecx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   RectInt v18; // [rsp+30h] [rbp-28h] BYREF
			// 
			//   v6 = levelIndex;
			//   if ( !byte_18D919E99 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator);
			//     byte_18D919E99 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1844, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1844, 0LL);
			//     if ( Patch )
			//     {
			//       *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_517(&v18, Patch, (Object *)this, level, v6, 0LL);
			//       return retstr;
			//     }
			// LABEL_8:
			//     sub_180B536AC(RECT_OFFSETS, v12);
			//   }
			//   v9 = 1 << (level & 0x1F);
			//   v10 = this.fields.m_atlasResolution >> ((level + 2) & 0x1F);
			//   v11 = (int)(float)((float)(1.0 - (float)(1.0 / (float)v9)) * (float)this.fields.m_atlasResolution);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator);
			//   RECT_OFFSETS = TypeInfo::HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator.static_fields.RECT_OFFSETS;
			//   if ( !RECT_OFFSETS )
			//     goto LABEL_8;
			//   v14 = *(_DWORD *)sub_18037A300(RECT_OFFSETS, v6);
			//   RECT_OFFSETS = TypeInfo::HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator.static_fields.RECT_OFFSETS;
			//   if ( !RECT_OFFSETS )
			//     goto LABEL_8;
			//   v15 = *(_DWORD *)(sub_18037A300(RECT_OFFSETS, v6) + 4) * v10;
			//   retstr.m_Width = v10;
			//   retstr.m_Height = v10;
			//   retstr.m_XMin = v11 + v10 * v14;
			//   retstr.m_YMin = v11 + v15;
			//   return retstr;
			// }
			// 
			return null;
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly Vector2Int[] RECT_OFFSETS;

		public int m_atlasResolution;

		public int m_levelCount;

		private bool[] m_slotOccupied;
	}
}
