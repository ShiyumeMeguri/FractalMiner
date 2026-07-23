using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class HGPunctualLightStaticAtlasAllocator // TypeDefIndex: 37852
	{
		// Fields
		private static readonly Vector2Int[] RECT_OFFSETS; // 0x00
		public int m_atlasResolution; // 0x10
		public int m_levelCount; // 0x14
		private bool[] m_slotOccupied; // 0x18
	
		// Properties
		public int SlotCount { get => default; } // 0x0000000189B4FBAC-0x0000000189B4FC04 
		// Int32 get_SlotCount()
		int32_t HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::get_SlotCount(
		        HGPunctualLightStaticAtlasAllocator *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  Boolean__Array *m_slotOccupied; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1953, 0LL) )
		  {
		    m_slotOccupied = this->fields.m_slotOccupied;
		    if ( m_slotOccupied )
		      return m_slotOccupied->max_length.size;
		LABEL_5:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1953, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Constructors
		public HGPunctualLightStaticAtlasAllocator() {} // Dummy constructor
		public HGPunctualLightStaticAtlasAllocator(int levelCount, int atlasResolution) {} // 0x000000018434B8C0-0x000000018434B930
		// HGPunctualLightStaticAtlasAllocator(Int32, Int32)
		void HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::HGPunctualLightStaticAtlasAllocator(
		        HGPunctualLightStaticAtlasAllocator *this,
		        int32_t levelCount,
		        int32_t atlasResolution,
		        MethodInfo *method)
		{
		  Type *v5; // rdx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  __int64 v8; // rdx
		  Boolean__Array *v9; // rcx
		  int32_t i; // r9d
		  Boolean__Array *m_slotOccupied; // rax
		  __int64 v12; // rax
		  MethodInfo *v13; // [rsp+20h] [rbp-8h]
		
		  this->fields.m_levelCount = levelCount;
		  this->fields.m_atlasResolution = atlasResolution;
		  this->fields.m_slotOccupied = (Boolean__Array *)il2cpp_array_new_specific_1(
		                                                    TypeInfo::System::Boolean,
		                                                    (unsigned int)(12 * levelCount + 4));
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_slotOccupied, v5, v6, v7, v13);
		  for ( i = 0; ; ++i )
		  {
		    m_slotOccupied = this->fields.m_slotOccupied;
		    if ( !m_slotOccupied )
		      sub_1800D8260(v9, v8);
		    if ( i >= m_slotOccupied->max_length.size )
		      break;
		    v9 = this->fields.m_slotOccupied;
		    if ( (unsigned int)i >= m_slotOccupied->max_length.size )
		      sub_1800D2AB0(v9, v8);
		    v12 = i;
		    v9->vector[v12] = 0;
		  }
		}
		
		static HGPunctualLightStaticAtlasAllocator() {} // 0x0000000183D76010-0x0000000183D76310
		// HGPunctualLightStaticAtlasAllocator()
		void HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::cctor(MethodInfo *method)
		{
		  __int64 v1; // rax
		  __int64 v2; // rcx
		  PropertyInfo_1 *v3; // r8
		  Int32__Array **v4; // r9
		  Type *static_fields; // rdx
		  MethodInfo *v6; // [rsp+50h] [rbp+28h]
		
		  v1 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector2Int, 16LL);
		  if ( !v1 )
		    sub_1800D8260(v2, 0LL);
		  if ( !*(_DWORD *)(v1 + 24) )
		    goto LABEL_20;
		  v2 = 0LL;
		  *(_QWORD *)(v1 + 32) = 0LL;
		  if ( *(_DWORD *)(v1 + 24) <= 1u )
		    goto LABEL_20;
		  v2 = 1LL;
		  *(_QWORD *)(v1 + 40) = 1LL;
		  if ( *(_DWORD *)(v1 + 24) <= 2u )
		    goto LABEL_20;
		  v2 = 2LL;
		  *(_QWORD *)(v1 + 48) = 2LL;
		  if ( *(_DWORD *)(v1 + 24) <= 3u )
		    goto LABEL_20;
		  v2 = 3LL;
		  *(_QWORD *)(v1 + 56) = 3LL;
		  if ( *(_DWORD *)(v1 + 24) <= 4u )
		    goto LABEL_20;
		  v2 = 0x100000000LL;
		  *(_QWORD *)(v1 + 64) = 0x100000000LL;
		  if ( *(_DWORD *)(v1 + 24) <= 5u )
		    goto LABEL_20;
		  v2 = 0x100000001LL;
		  *(_QWORD *)(v1 + 72) = 0x100000001LL;
		  if ( *(_DWORD *)(v1 + 24) <= 6u )
		    goto LABEL_20;
		  v2 = 0x100000002LL;
		  *(_QWORD *)(v1 + 80) = 0x100000002LL;
		  if ( *(_DWORD *)(v1 + 24) <= 7u )
		    goto LABEL_20;
		  v2 = 0x100000003LL;
		  *(_QWORD *)(v1 + 88) = 0x100000003LL;
		  if ( *(_DWORD *)(v1 + 24) <= 8u )
		    goto LABEL_20;
		  v2 = 0x200000000LL;
		  *(_QWORD *)(v1 + 96) = 0x200000000LL;
		  if ( *(_DWORD *)(v1 + 24) <= 9u )
		    goto LABEL_20;
		  v2 = 0x200000001LL;
		  *(_QWORD *)(v1 + 104) = 0x200000001LL;
		  if ( *(_DWORD *)(v1 + 24) <= 0xAu )
		    goto LABEL_20;
		  v2 = 0x300000000LL;
		  *(_QWORD *)(v1 + 112) = 0x300000000LL;
		  if ( *(_DWORD *)(v1 + 24) <= 0xBu )
		    goto LABEL_20;
		  v2 = 0x300000001LL;
		  *(_QWORD *)(v1 + 120) = 0x300000001LL;
		  if ( *(_DWORD *)(v1 + 24) <= 0xCu
		    || (v2 = 0x200000002LL, *(_QWORD *)(v1 + 128) = 0x200000002LL, *(_DWORD *)(v1 + 24) <= 0xDu)
		    || (v2 = 0x200000003LL, *(_QWORD *)(v1 + 136) = 0x200000003LL, *(_DWORD *)(v1 + 24) <= 0xEu)
		    || (v2 = 0x300000002LL, *(_QWORD *)(v1 + 144) = 0x300000002LL, *(_DWORD *)(v1 + 24) <= 0xFu) )
		  {
		LABEL_20:
		    sub_1800D2AB0(v2, 0LL);
		  }
		  *(_QWORD *)(v1 + 152) = 0x300000003LL;
		  static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator->static_fields;
		  static_fields->klass = (Type__Class *)v1;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator->static_fields,
		    static_fields,
		    v3,
		    v4,
		    v6);
		}
		
	
		// Methods
		public int TryAlloc(int level) => default; // 0x0000000189B4FABC-0x0000000189B4FBAC
		// Int32 TryAlloc(Int32)
		int32_t HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::TryAlloc(
		        HGPunctualLightStaticAtlasAllocator *this,
		        int32_t level,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  Boolean__Array *m_slotOccupied; // rcx
		  int32_t v7; // r8d
		  int32_t result; // eax
		  Object *v9; // rax
		  String *v10; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  int32_t v12; // [rsp+48h] [rbp+20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1958, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1958, 0LL);
		    if ( !Patch )
		LABEL_17:
		      sub_1800D8260(m_slotOccupied, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_235(
		             (ILFixDynamicMethodWrapper_6 *)Patch,
		             (Object *)this,
		             (NaviDirection__Enum)level,
		             0LL);
		  }
		  else if ( level < 0 || level >= this->fields.m_levelCount )
		  {
		    v12 = level;
		    v9 = (Object *)il2cpp_value_box_0(TypeInfo::System::Int32, &v12);
		    v10 = System::String::Format((String *)"HGPunctualLightAtlasAllocator: Invalid level {0} requested", v9, 0LL);
		    HG::Rendering::HGRPLogger::LogError(v10, 0LL);
		    return -1;
		  }
		  else
		  {
		    v5 = 16LL;
		    if ( level != this->fields.m_levelCount - 1 )
		      v5 = 12LL;
		    m_slotOccupied = this->fields.m_slotOccupied;
		    v7 = 12 * level;
		    while ( 1 )
		    {
		      if ( !m_slotOccupied )
		        goto LABEL_17;
		      if ( (unsigned int)v7 >= m_slotOccupied->max_length.size )
		        sub_1800D2AB0(m_slotOccupied, v5);
		      if ( !m_slotOccupied->vector[v7] )
		        break;
		      ++v7;
		      if ( -12 * level + v7 >= (int)v5 )
		        return -1;
		    }
		    result = v7;
		    this->fields.m_slotOccupied->vector[v7] = 1;
		  }
		  return result;
		}
		
		public bool Free(int slotIndex) => default; // 0x0000000189B4F788-0x0000000189B4F840
		// Boolean Free(Int32)
		bool HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::Free(
		        HGPunctualLightStaticAtlasAllocator *this,
		        int32_t slotIndex,
		        MethodInfo *method)
		{
		  __int64 v3; // rbx
		  __int64 v5; // rcx
		  Boolean__Array *m_slotOccupied; // rdx
		  Object *v7; // rax
		  String *v8; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  int v11; // [rsp+48h] [rbp+20h] BYREF
		
		  v3 = slotIndex;
		  if ( IFix::WrappersManagerImpl::IsPatched(1952, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1952, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_17(
		               (ILFixDynamicMethodWrapper_13 *)Patch,
		               (Object *)this,
		               (NaviDirection__Enum)v3,
		               0LL);
		LABEL_10:
		    sub_1800D8260(v5, m_slotOccupied);
		  }
		  m_slotOccupied = this->fields.m_slotOccupied;
		  if ( !m_slotOccupied )
		    goto LABEL_10;
		  if ( (unsigned int)v3 >= m_slotOccupied->max_length.size )
		    goto LABEL_8;
		  if ( !m_slotOccupied->vector[v3] )
		  {
		    v11 = v3;
		    v7 = (Object *)il2cpp_value_box_0(TypeInfo::System::Int32, &v11);
		    v8 = System::String::Format(
		           (String *)"HGPunctualLightAtlasAllocator: Slot {0} is already empty, failed to release!",
		           v7,
		           0LL);
		    HG::Rendering::HGRPLogger::LogWarning(v8, 0LL);
		    return 0;
		  }
		  if ( (unsigned int)v3 >= m_slotOccupied->max_length.size )
		LABEL_8:
		    sub_1800D2AB0(v5, m_slotOccupied);
		  m_slotOccupied->vector[v3] = 0;
		  return 1;
		}
		
		public void FreeAll() {} // 0x0000000189B4F71C-0x0000000189B4F788
		// Void FreeAll()
		void HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::FreeAll(
		        HGPunctualLightStaticAtlasAllocator *this,
		        MethodInfo *method)
		{
		  Boolean__Array *v3; // rcx
		  __int64 v4; // rdx
		  Boolean__Array *m_slotOccupied; // rax
		  __int64 v6; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1944, 0LL) )
		  {
		    v4 = 0LL;
		    while ( 1 )
		    {
		      m_slotOccupied = this->fields.m_slotOccupied;
		      if ( !m_slotOccupied )
		        break;
		      if ( (int)v4 >= m_slotOccupied->max_length.size )
		        return;
		      v3 = this->fields.m_slotOccupied;
		      if ( (unsigned int)v4 >= m_slotOccupied->max_length.size )
		        sub_1800D2AB0(v3, v4);
		      v6 = (int)v4;
		      v4 = (unsigned int)(v4 + 1);
		      v3->vector[v6] = 0;
		    }
		LABEL_9:
		    sub_1800D8260(v3, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1944, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public int GetSlotLevelFromIndex(int slotIndex) => default; // 0x0000000189B4FA40-0x0000000189B4FABC
		// Int32 GetSlotLevelFromIndex(Int32)
		int32_t HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::GetSlotLevelFromIndex(
		        HGPunctualLightStaticAtlasAllocator *this,
		        int32_t slotIndex,
		        MethodInfo *method)
		{
		  int32_t m_levelCount; // ebx
		  int32_t v6; // ebx
		  int32_t v7; // edx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1956, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1956, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_235(
		             (ILFixDynamicMethodWrapper_6 *)Patch,
		             (Object *)this,
		             (NaviDirection__Enum)slotIndex,
		             0LL);
		  }
		  else
		  {
		    m_levelCount = this->fields.m_levelCount;
		    sub_1800036A0(TypeInfo::System::Math);
		    v6 = m_levelCount - 1;
		    v7 = slotIndex / 12;
		    if ( slotIndex / 12 > v6 )
		      return v6;
		    return v7;
		  }
		}
		
		public RectInt GetRectFromSlotIndex(int slotIndex) => default; // 0x0000000189B4F97C-0x0000000189B4FA40
		// RectInt GetRectFromSlotIndex(Int32)
		RectInt *HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::GetRectFromSlotIndex(
		        RectInt *__return_ptr retstr,
		        HGPunctualLightStaticAtlasAllocator *this,
		        int32_t slotIndex,
		        MethodInfo *method)
		{
		  int32_t m_levelCount; // ebx
		  int v8; // ebx
		  int32_t v9; // edx
		  RectInt *RectFromLevelIndex; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  RectInt v14; // xmm0
		  RectInt *result; // rax
		  RectInt v16; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2178, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2178, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v13, v12);
		    RectFromLevelIndex = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_872(&v16, Patch, (Object *)this, slotIndex, 0LL);
		  }
		  else
		  {
		    m_levelCount = this->fields.m_levelCount;
		    sub_1800036A0(TypeInfo::System::Math);
		    v8 = m_levelCount - 1;
		    v9 = slotIndex / 12;
		    if ( slotIndex / 12 > v8 )
		      v9 = v8;
		    RectFromLevelIndex = HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::GetRectFromLevelIndex(
		                           &v16,
		                           this,
		                           v9,
		                           slotIndex - 12 * v9,
		                           0LL);
		  }
		  v14 = *RectFromLevelIndex;
		  result = retstr;
		  *retstr = v14;
		  return result;
		}
		
		public RectInt GetRectFromLevelIndex(int level, int levelIndex) => default; // 0x0000000189B4F840-0x0000000189B4F97C
		// RectInt GetRectFromLevelIndex(Int32, Int32)
		RectInt *HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::GetRectFromLevelIndex(
		        RectInt *__return_ptr retstr,
		        HGPunctualLightStaticAtlasAllocator *this,
		        int32_t level,
		        int32_t levelIndex,
		        MethodInfo *method)
		{
		  __int64 v6; // rbp
		  __m128i v9; // xmm0
		  int32_t v10; // esi
		  int v11; // r14d
		  __int64 v12; // rdx
		  Vector2Int__Array *RECT_OFFSETS; // rcx
		  int v14; // edi
		  int v15; // ecx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  RectInt v18; // [rsp+30h] [rbp-18h] BYREF
		
		  v6 = levelIndex;
		  if ( IFix::WrappersManagerImpl::IsPatched(2179, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2179, 0LL);
		    if ( Patch )
		    {
		      *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_659(&v18, Patch, (Object *)this, level, v6, 0LL);
		      return retstr;
		    }
		LABEL_6:
		    sub_1800D8260(RECT_OFFSETS, v12);
		  }
		  v9 = _mm_cvtsi32_si128(this->fields.m_atlasResolution);
		  v10 = this->fields.m_atlasResolution >> ((level + 2) & 0x1F);
		  v11 = (int)(float)((float)(1.0 - (float)(1.0 / (float)(1 << (level & 0x1F)))) * _mm_cvtepi32_ps(v9).m128_f32[0]);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator);
		  RECT_OFFSETS = TypeInfo::HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator->static_fields->RECT_OFFSETS;
		  if ( !RECT_OFFSETS )
		    goto LABEL_6;
		  v14 = *(_DWORD *)sub_1803C0794(RECT_OFFSETS, v6);
		  RECT_OFFSETS = TypeInfo::HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator->static_fields->RECT_OFFSETS;
		  if ( !RECT_OFFSETS )
		    goto LABEL_6;
		  v15 = *(_DWORD *)(sub_1803C0794(RECT_OFFSETS, v6) + 4) * v10;
		  retstr->m_Width = v10;
		  retstr->m_Height = v10;
		  retstr->m_XMin = v11 + v10 * v14;
		  retstr->m_YMin = v11 + v15;
		  return retstr;
		}
		
	}
}
