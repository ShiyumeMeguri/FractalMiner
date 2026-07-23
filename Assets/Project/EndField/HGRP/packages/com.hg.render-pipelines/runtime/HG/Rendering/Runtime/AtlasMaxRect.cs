using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class AtlasMaxRect // TypeDefIndex: 38078
	{
		// Fields
		private readonly int m_binWidth; // 0x10
		private readonly int m_binHeight; // 0x14
		private readonly List<RectInt> m_newFreeRectangles; // 0x18
		private readonly List<RectInt> m_freeRectangles; // 0x20
		private readonly Dictionary<ValueTuple<int, int>, RectInt> m_usedRectangles; // 0x28
		private int m_usedRectSize; // 0x30
		private int m_maxFreeRectWidth; // 0x34
		private int m_maxFreeRectHeight; // 0x38
	
		// Properties
		public bool empty { get => default; } // 0x0000000189B7136C-0x0000000189B713BC 
		// Boolean get_empty()
		bool HG::Rendering::Runtime::AtlasMaxRect::get_empty(AtlasMaxRect *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2738, 0LL) )
		    return this->fields.m_usedRectSize == 0;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2738, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public int maxFreeRectWidth { get => default; } // 0x0000000189B71408-0x0000000189B71454 
		// Int32 get_maxFreeRectWidth()
		int32_t HG::Rendering::Runtime::AtlasMaxRect::get_maxFreeRectWidth(AtlasMaxRect *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2739, 0LL) )
		    return this->fields.m_maxFreeRectWidth;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2739, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		public int maxFreeRectHeight { get => default; } // 0x0000000189B713BC-0x0000000189B71408 
		// Int32 get_maxFreeRectHeight()
		int32_t HG::Rendering::Runtime::AtlasMaxRect::get_maxFreeRectHeight(AtlasMaxRect *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2740, 0LL) )
		    return this->fields.m_maxFreeRectHeight;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2740, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Nested types
		public enum FreeRectChoiceHeuristic // TypeDefIndex: 38077
		{
			RectBestShortSideFit = 0,
			RectBestLongSideFit = 1,
			RectBestAreaFit = 2,
			RectBottomLeftRule = 3,
			RectContactPointRule = 4
		}
	
		// Constructors
		public AtlasMaxRect() {} // Dummy constructor
		public AtlasMaxRect(int width, int height) {} // 0x000000018425F350-0x000000018425F490
		// AtlasMaxRect(Int32, Int32)
		void HG::Rendering::Runtime::AtlasMaxRect::AtlasMaxRect(
		        AtlasMaxRect *this,
		        int32_t width,
		        int32_t height,
		        MethodInfo *method)
		{
		  LowLevelList_1_System_Object_ *v7; // rax
		  __int64 v8; // rdx
		  Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *m_usedRectangles; // rcx
		  List_1_UnityEngine_RectInt_ *v10; // rdi
		  Type *v11; // rdx
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  LowLevelList_1_System_Object_ *v14; // rax
		  List_1_UnityEngine_RectInt_ *v15; // rdi
		  Type *v16; // rdx
		  PropertyInfo_1 *v17; // r8
		  Int32__Array **v18; // r9
		  Dictionary_2_System_ValueTuple_2_Int32_Int32_UnityEngine_RectInt_ *v19; // rax
		  Dictionary_2_System_ValueTuple_2_Int32_Int32_UnityEngine_RectInt_ *v20; // rdi
		  Type *v21; // rdx
		  PropertyInfo_1 *v22; // r8
		  Int32__Array **v23; // r9
		  MethodInfo *v24; // [rsp+20h] [rbp-18h] BYREF
		  int32_t v25; // [rsp+28h] [rbp-10h]
		  int32_t v26; // [rsp+2Ch] [rbp-Ch]
		
		  v7 = (LowLevelList_1_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<UnityEngine::RectInt>);
		  v10 = (List_1_UnityEngine_RectInt_ *)v7;
		  if ( !v7 )
		    goto LABEL_8;
		  System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
		    v7,
		    MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::List);
		  this->fields.m_newFreeRectangles = v10;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_newFreeRectangles, v11, v12, v13, v24);
		  v14 = (LowLevelList_1_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<UnityEngine::RectInt>);
		  v15 = (List_1_UnityEngine_RectInt_ *)v14;
		  if ( !v14 )
		    goto LABEL_8;
		  System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
		    v14,
		    MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::List);
		  this->fields.m_freeRectangles = v15;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_freeRectangles, v16, v17, v18, v24);
		  v19 = (Dictionary_2_System_ValueTuple_2_Int32_Int32_UnityEngine_RectInt_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<System::ValueTuple<int,int>,UnityEngine::RectInt>);
		  v20 = v19;
		  if ( !v19 )
		    goto LABEL_8;
		  System::Collections::Generic::Dictionary<System::ValueTuple<int,int>,UnityEngine::RectInt>::Dictionary(
		    v19,
		    MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<int,int>,UnityEngine::RectInt>::Dictionary);
		  this->fields.m_usedRectangles = v20;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_usedRectangles, v21, v22, v23, v24);
		  m_usedRectangles = (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)this->fields.m_usedRectangles;
		  this->fields.m_binWidth = width;
		  this->fields.m_binHeight = height;
		  this->fields.m_usedRectSize = 0;
		  this->fields.m_maxFreeRectWidth = width;
		  this->fields.m_maxFreeRectHeight = height;
		  if ( !m_usedRectangles )
		    goto LABEL_8;
		  System::Collections::Generic::Dictionary<Beyond::Gameplay::WorldSetting::MissionImportanceAndType,System::Object>::Clear(
		    m_usedRectangles,
		    MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<int,int>,UnityEngine::RectInt>::Clear);
		  m_usedRectangles = (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)this->fields.m_freeRectangles;
		  if ( !m_usedRectangles
		    || (++HIDWORD(m_usedRectangles->fields._entries),
		        LODWORD(m_usedRectangles->fields._entries) = 0,
		        m_usedRectangles = (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)this->fields.m_freeRectangles,
		        v24 = 0LL,
		        v25 = width,
		        v26 = height,
		        !m_usedRectangles) )
		  {
		LABEL_8:
		    sub_1800D8260(m_usedRectangles, v8);
		  }
		  sub_184565900(m_usedRectangles, &v24, MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::Add);
		}
		
	
		// Methods
		public RectInt InsertRect(int width, int height) => default; // 0x0000000189B6E9C8-0x0000000189B6EBE4
		// RectInt InsertRect(Int32, Int32)
		RectInt *HG::Rendering::Runtime::AtlasMaxRect::InsertRect(
		        RectInt *__return_ptr retstr,
		        AtlasMaxRect *this,
		        int32_t width,
		        int32_t height,
		        MethodInfo *method)
		{
		  int v8; // r14d
		  List_1_UnityEngine_RectInt_ *v9; // rdx
		  __int64 v10; // rcx
		  int v11; // r15d
		  int32_t m_XMin; // r13d
		  int32_t i; // edi
		  List_1_UnityEngine_RectInt_ *m_freeRectangles; // rax
		  int v15; // r14d
		  RectInt v16; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  RectInt *result; // rax
		  RectInt node; // [rsp+38h] [rbp-51h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v20; // [rsp+48h] [rbp-41h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v21; // [rsp+58h] [rbp-31h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v22; // [rsp+68h] [rbp-21h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v23; // [rsp+78h] [rbp-11h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v24; // [rsp+88h] [rbp-1h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v25; // [rsp+98h] [rbp+Fh] BYREF
		  RectInt v26; // [rsp+A8h] [rbp+1Fh] BYREF
		
		  v8 = width;
		  if ( IFix::WrappersManagerImpl::IsPatched(1633, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1633, 0LL);
		    if ( !Patch )
		LABEL_23:
		      sub_1800D8260(v10, v9);
		    v16 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_659(&v26, Patch, (Object *)this, v8, height, 0LL);
		  }
		  else
		  {
		    v11 = 0x7FFFFFFF;
		    node = 0LL;
		    m_XMin = 0x7FFFFFFF;
		    for ( i = 0; ; ++i )
		    {
		      m_freeRectangles = this->fields.m_freeRectangles;
		      if ( !m_freeRectangles )
		        goto LABEL_23;
		      if ( i >= m_freeRectangles->fields._size )
		        break;
		      System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		        &v20,
		        (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_freeRectangles,
		        i,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		      if ( SLODWORD(v20.target) >= v8 )
		      {
		        v9 = this->fields.m_freeRectangles;
		        if ( !v9 )
		          goto LABEL_23;
		        System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		          &v21,
		          (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)v9,
		          i,
		          MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		        if ( SHIDWORD(v21.target) >= height )
		        {
		          v9 = this->fields.m_freeRectangles;
		          if ( !v9 )
		            goto LABEL_23;
		          System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		            &v22,
		            (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)v9,
		            i,
		            MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		          v15 = height + HIDWORD(v22.ptr);
		          if ( height + HIDWORD(v22.ptr) < v11 )
		            goto LABEL_13;
		          if ( v15 == v11 )
		          {
		            v9 = this->fields.m_freeRectangles;
		            if ( !v9 )
		              goto LABEL_23;
		            System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		              &v23,
		              (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)v9,
		              i,
		              MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		            if ( SLODWORD(v23.ptr) < m_XMin )
		            {
		LABEL_13:
		              v9 = this->fields.m_freeRectangles;
		              if ( !v9 )
		                goto LABEL_23;
		              System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		                &v24,
		                (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)v9,
		                i,
		                MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		              v9 = this->fields.m_freeRectangles;
		              node.m_XMin = (int32_t)v24.ptr;
		              if ( !v9 )
		                goto LABEL_23;
		              System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		                &v25,
		                (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)v9,
		                i,
		                MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		              v11 = v15;
		              v9 = this->fields.m_freeRectangles;
		              node.m_YMin = HIDWORD(v25.ptr);
		              node.m_Width = width;
		              node.m_Height = height;
		              if ( !v9 )
		                goto LABEL_23;
		              System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		                (ObjectTranslator_LuaCSFunctionPtr *)&v26,
		                (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)v9,
		                i,
		                MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		              m_XMin = v26.m_XMin;
		            }
		          }
		          v8 = width;
		        }
		      }
		    }
		    if ( node.m_Height )
		      HG::Rendering::Runtime::AtlasMaxRect::_PlaceRect(this, &node, 0LL);
		    v16 = node;
		  }
		  result = retstr;
		  *retstr = v16;
		  return result;
		}
		
		public RectInt InsertRectBestShortSideFit(int width, int height) => default; // 0x0000000189B6E7F0-0x0000000189B6E8E4
		// RectInt InsertRectBestShortSideFit(Int32, Int32)
		RectInt *HG::Rendering::Runtime::AtlasMaxRect::InsertRectBestShortSideFit(
		        RectInt *__return_ptr retstr,
		        AtlasMaxRect *this,
		        int32_t width,
		        int32_t height,
		        MethodInfo *method)
		{
		  RectInt *PositionForNewNodeBestShortSideFit; // rax
		  RectInt v10; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  RectInt *result; // rax
		  int32_t v15; // [rsp+40h] [rbp-38h] BYREF
		  RectInt node; // [rsp+48h] [rbp-30h] BYREF
		  RectInt v17; // [rsp+58h] [rbp-20h] BYREF
		  int32_t v18; // [rsp+80h] [rbp+8h] BYREF
		
		  v15 = 0;
		  v18 = 0;
		  node = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2741, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2741, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v13, v12);
		    PositionForNewNodeBestShortSideFit = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_659(
		                                           &v17,
		                                           Patch,
		                                           (Object *)this,
		                                           width,
		                                           height,
		                                           0LL);
		    goto LABEL_7;
		  }
		  PositionForNewNodeBestShortSideFit = HG::Rendering::Runtime::AtlasMaxRect::_FindPositionForNewNodeBestShortSideFit(
		                                         &v17,
		                                         this,
		                                         width,
		                                         height,
		                                         &v15,
		                                         &v18,
		                                         0LL);
		  node = *PositionForNewNodeBestShortSideFit;
		  if ( !_mm_srli_si128(*(__m128i *)&node, 8).m128i_u32[1] )
		  {
		LABEL_7:
		    v10 = *PositionForNewNodeBestShortSideFit;
		    goto LABEL_8;
		  }
		  HG::Rendering::Runtime::AtlasMaxRect::_PlaceRect(this, &node, 0LL);
		  v10 = node;
		LABEL_8:
		  result = retstr;
		  *retstr = v10;
		  return result;
		}
		
		public RectInt InsertRectContactPoint(int width, int height) => default; // 0x0000000189B6E8E4-0x0000000189B6E9C8
		// RectInt InsertRectContactPoint(Int32, Int32)
		RectInt *HG::Rendering::Runtime::AtlasMaxRect::InsertRectContactPoint(
		        RectInt *__return_ptr retstr,
		        AtlasMaxRect *this,
		        int32_t width,
		        int32_t height,
		        MethodInfo *method)
		{
		  RectInt *PositionForNewNodeContactPoint; // rax
		  RectInt v10; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  RectInt *result; // rax
		  RectInt node; // [rsp+30h] [rbp-28h] BYREF
		  RectInt v16; // [rsp+40h] [rbp-18h] BYREF
		  int32_t v17; // [rsp+60h] [rbp+8h] BYREF
		
		  v17 = 0;
		  node = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2743, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2743, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v13, v12);
		    PositionForNewNodeContactPoint = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_659(
		                                       &v16,
		                                       Patch,
		                                       (Object *)this,
		                                       width,
		                                       height,
		                                       0LL);
		    goto LABEL_7;
		  }
		  PositionForNewNodeContactPoint = HG::Rendering::Runtime::AtlasMaxRect::_FindPositionForNewNodeContactPoint(
		                                     &v16,
		                                     this,
		                                     width,
		                                     height,
		                                     &v17,
		                                     0LL);
		  node = *PositionForNewNodeContactPoint;
		  if ( !_mm_srli_si128(*(__m128i *)&node, 8).m128i_u32[1] )
		  {
		LABEL_7:
		    v10 = *PositionForNewNodeContactPoint;
		    goto LABEL_8;
		  }
		  HG::Rendering::Runtime::AtlasMaxRect::_PlaceRect(this, &node, 0LL);
		  v10 = node;
		LABEL_8:
		  result = retstr;
		  *retstr = v10;
		  return result;
		}
		
		public RectInt InsertRectBestLongSideFit(int width, int height) => default; // 0x0000000189B6E6FC-0x0000000189B6E7F0
		// RectInt InsertRectBestLongSideFit(Int32, Int32)
		RectInt *HG::Rendering::Runtime::AtlasMaxRect::InsertRectBestLongSideFit(
		        RectInt *__return_ptr retstr,
		        AtlasMaxRect *this,
		        int32_t width,
		        int32_t height,
		        MethodInfo *method)
		{
		  RectInt *PositionForNewNodeBestLongSideFit; // rax
		  RectInt v10; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  RectInt *result; // rax
		  int32_t v15; // [rsp+40h] [rbp-38h] BYREF
		  RectInt node; // [rsp+48h] [rbp-30h] BYREF
		  RectInt v17; // [rsp+58h] [rbp-20h] BYREF
		  int32_t v18; // [rsp+80h] [rbp+8h] BYREF
		
		  v15 = 0;
		  v18 = 0;
		  node = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2747, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2747, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v13, v12);
		    PositionForNewNodeBestLongSideFit = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_659(
		                                          &v17,
		                                          Patch,
		                                          (Object *)this,
		                                          width,
		                                          height,
		                                          0LL);
		    goto LABEL_7;
		  }
		  PositionForNewNodeBestLongSideFit = HG::Rendering::Runtime::AtlasMaxRect::_FindPositionForNewNodeBestLongSideFit(
		                                        &v17,
		                                        this,
		                                        width,
		                                        height,
		                                        &v15,
		                                        &v18,
		                                        0LL);
		  node = *PositionForNewNodeBestLongSideFit;
		  if ( !_mm_srli_si128(*(__m128i *)&node, 8).m128i_u32[1] )
		  {
		LABEL_7:
		    v10 = *PositionForNewNodeBestLongSideFit;
		    goto LABEL_8;
		  }
		  HG::Rendering::Runtime::AtlasMaxRect::_PlaceRect(this, &node, 0LL);
		  v10 = node;
		LABEL_8:
		  result = retstr;
		  *retstr = v10;
		  return result;
		}
		
		public RectInt InsertRectBestAreaFit(int width, int height) => default; // 0x0000000189B6E608-0x0000000189B6E6FC
		// RectInt InsertRectBestAreaFit(Int32, Int32)
		RectInt *HG::Rendering::Runtime::AtlasMaxRect::InsertRectBestAreaFit(
		        RectInt *__return_ptr retstr,
		        AtlasMaxRect *this,
		        int32_t width,
		        int32_t height,
		        MethodInfo *method)
		{
		  RectInt *PositionForNewNodeBestAreaFit; // rax
		  RectInt v10; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  RectInt *result; // rax
		  int32_t v15; // [rsp+40h] [rbp-38h] BYREF
		  RectInt node; // [rsp+48h] [rbp-30h] BYREF
		  RectInt v17; // [rsp+58h] [rbp-20h] BYREF
		  int32_t v18; // [rsp+80h] [rbp+8h] BYREF
		
		  v15 = 0;
		  v18 = 0;
		  node = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2749, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2749, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v13, v12);
		    PositionForNewNodeBestAreaFit = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_659(
		                                      &v17,
		                                      Patch,
		                                      (Object *)this,
		                                      width,
		                                      height,
		                                      0LL);
		    goto LABEL_7;
		  }
		  PositionForNewNodeBestAreaFit = HG::Rendering::Runtime::AtlasMaxRect::_FindPositionForNewNodeBestAreaFit(
		                                    &v17,
		                                    this,
		                                    width,
		                                    height,
		                                    &v15,
		                                    &v18,
		                                    0LL);
		  node = *PositionForNewNodeBestAreaFit;
		  if ( !_mm_srli_si128(*(__m128i *)&node, 8).m128i_u32[1] )
		  {
		LABEL_7:
		    v10 = *PositionForNewNodeBestAreaFit;
		    goto LABEL_8;
		  }
		  HG::Rendering::Runtime::AtlasMaxRect::_PlaceRect(this, &node, 0LL);
		  v10 = node;
		LABEL_8:
		  result = retstr;
		  *retstr = v10;
		  return result;
		}
		
		public void InsertRects(List<RectInt> rects, List<RectInt> dst, FreeRectChoiceHeuristic method) {} // 0x0000000189B6EBE4-0x0000000189B6EDE0
		// Void InsertRects(List`1[UnityEngine.RectInt], List`1[UnityEngine.RectInt], AtlasMaxRect+FreeRectChoiceHeuristic)
		void HG::Rendering::Runtime::AtlasMaxRect::InsertRects(
		        AtlasMaxRect *this,
		        List_1_UnityEngine_RectInt_ *rects,
		        List_1_UnityEngine_RectInt_ *dst,
		        AtlasMaxRect_FreeRectChoiceHeuristic__Enum method_1,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  int32_t v11; // r15d
		  int32_t v12; // r14d
		  int32_t v13; // r12d
		  int32_t v14; // esi
		  RectInt v15; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  int32_t v17; // [rsp+48h] [rbp-51h] BYREF
		  int32_t v18[3]; // [rsp+4Ch] [rbp-4Dh] BYREF
		  RectInt node; // [rsp+58h] [rbp-41h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v20; // [rsp+68h] [rbp-31h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v21; // [rsp+78h] [rbp-21h] BYREF
		  RectInt v22; // [rsp+88h] [rbp-11h] BYREF
		  RectInt v23; // [rsp+98h] [rbp-1h] BYREF
		  RectInt v24; // [rsp+A8h] [rbp+Fh] BYREF
		
		  v18[0] = 0;
		  v17 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(2751, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2751, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_296(
		        (ILFixDynamicMethodWrapper_6 *)Patch,
		        (Object *)this,
		        (Object *)rects,
		        (Object *)dst,
		        (UIScrollRectEdgeRedDot_ERedDotState__Enum)method_1,
		        0LL);
		      return;
		    }
		LABEL_15:
		    sub_1800D8260(v10, v9);
		  }
		  if ( !dst )
		    goto LABEL_15;
		  ++dst->fields._version;
		  dst->fields._size = 0;
		  if ( !rects )
		    goto LABEL_15;
		  while ( rects->fields._size > 0 )
		  {
		    v11 = 0x7FFFFFFF;
		    v12 = -1;
		    v13 = 0x7FFFFFFF;
		    v14 = 0;
		    node = 0LL;
		    while ( v14 < rects->fields._size )
		    {
		      System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		        &v21,
		        (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)rects,
		        v14,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		      System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		        &v20,
		        (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)rects,
		        v14,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		      v15 = *HG::Rendering::Runtime::AtlasMaxRect::_ScoreRect(
		               &v24,
		               this,
		               (int32_t)v21.target,
		               SHIDWORD(v20.target),
		               method_1,
		               v18,
		               &v17,
		               0LL);
		      if ( v18[0] < v11 || v18[0] == v11 && v17 < v13 )
		      {
		        v13 = v17;
		        v11 = v18[0];
		        node = v15;
		        v12 = v14;
		      }
		      ++v14;
		    }
		    if ( v12 == -1 )
		      break;
		    HG::Rendering::Runtime::AtlasMaxRect::_PlaceRect(this, &node, 0LL);
		    v22 = node;
		    sub_184565900(dst, &v22, MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::Add);
		    System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		      (ObjectTranslator_LuaCSFunctionPtr *)&v23,
		      (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)rects,
		      rects->fields._size - 1,
		      MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		    v22 = v23;
		    System::Collections::Generic::List<Beyond::NPC::Animation::NPCCrowdLodSettingConfig::FNPCCrowdLodSetting>::set_Item(
		      (List_1_Beyond_NPC_Animation_NPCCrowdLodSettingConfig_FNPCCrowdLodSetting_ *)rects,
		      v12,
		      (NPCCrowdLodSettingConfig_FNPCCrowdLodSetting *)&v22,
		      MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::set_Item);
		    System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::RemoveAt(
		      (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)rects,
		      rects->fields._size - 1,
		      MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::RemoveAt);
		  }
		}
		
		public void RemoveRect([IsReadOnly] in RectInt rect) {} // 0x0000000189B6EDE0-0x0000000189B6EEC8
		// Void RemoveRect(RectInt ByRef)
		void HG::Rendering::Runtime::AtlasMaxRect::RemoveRect(AtlasMaxRect *this, RectInt *rect, MethodInfo *method)
		{
		  __int64 v5; // rdx
		  Dictionary_2_System_ValueTuple_2_Int32_Int32_UnityEngine_RectInt_ *m_usedRectangles; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ValueTuple_2_Int32_Int32_ key; // [rsp+58h] [rbp+20h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1621, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1621, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_656(Patch, (Object *)this, rect, 0LL);
		      return;
		    }
		LABEL_8:
		    sub_1800D8260(m_usedRectangles, v5);
		  }
		  HG::Rendering::Runtime::AtlasMaxRect::_PlaceFreeRect(this, rect, 0LL);
		  m_usedRectangles = this->fields.m_usedRectangles;
		  key.Item1 = _mm_cvtsi128_si32(*(__m128i *)rect);
		  if ( !m_usedRectangles )
		    goto LABEL_8;
		  key.Item2 = HIDWORD(*(_QWORD *)&rect->m_XMin);
		  if ( System::Collections::Generic::Dictionary<System::ValueTuple<int,int>,UnityEngine::RectInt>::Remove(
		         m_usedRectangles,
		         key,
		         MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<int,int>,UnityEngine::RectInt>::Remove) )
		  {
		    this->fields.m_usedRectSize -= *(_QWORD *)&rect->m_Width * HIDWORD(*(_QWORD *)&rect->m_Width);
		  }
		  else
		  {
		    HG::Rendering::HGRPLogger::LogError<int,int,int,int>(
		      (String *)"Trying to remove a rectangle that has not been inserted: (x,y)=({0},{1}) (w,h)=({2},{3})",
		      *(_QWORD *)&rect->m_XMin,
		      HIDWORD(*(_QWORD *)&rect->m_XMin),
		      *(_QWORD *)&rect->m_Width,
		      HIDWORD(*(_QWORD *)&rect->m_Width),
		      MethodInfo::HG::Rendering::HGRPLogger::LogError<int,int,int,int>);
		  }
		  HG::Rendering::Runtime::AtlasMaxRect::_RecalculateMaxFreeRectWidthHeight(this, 0LL);
		}
		
		public void FreeRects(List<RectInt> rects) {} // 0x0000000189B6E444-0x0000000189B6E608
		// Void FreeRects(List`1[UnityEngine.RectInt])
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::AtlasMaxRect::FreeRects(
		        AtlasMaxRect *this,
		        List_1_UnityEngine_RectInt_ *rects,
		        MethodInfo *method)
		{
		  AtlasMaxRect *v4; // rbx
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  __int64 v7; // rdx
		  Dictionary_2_System_ValueTuple_2_Int32_Int32_UnityEngine_RectInt_ *m_usedRectangles; // rcx
		  int32_t m_XMin; // edi
		  int32_t m_YMin; // esi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  Il2CppExceptionWrapper *v14; // [rsp+30h] [rbp-68h] BYREF
		  RectInt node; // [rsp+38h] [rbp-60h] BYREF
		  List_1_T_Enumerator_Beyond_NPC_Animation_NPCCrowdLodSettingConfig_FNPCCrowdLodSetting_ v16; // [rsp+48h] [rbp-50h] BYREF
		  List_1_T_Enumerator_Beyond_NPC_Animation_NPCCrowdLodSettingConfig_FNPCCrowdLodSetting_ v17; // [rsp+68h] [rbp-30h] BYREF
		
		  v4 = this;
		  if ( IFix::WrappersManagerImpl::IsPatched(2754, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2754, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v13, v12);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)v4,
		      (Object *)rects,
		      0LL);
		  }
		  else
		  {
		    if ( !rects )
		      sub_1800D8260(v6, v5);
		    System::Collections::Generic::List<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::CoreZoneEntry>::GetEnumerator(
		      (List_1_T_Enumerator_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)&v16,
		      (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)rects,
		      MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::GetEnumerator);
		    v17 = v16;
		    v16._list = 0LL;
		    *(_QWORD *)&v16._index = &v17;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::NPC::Animation::NPCCrowdLodSettingConfig::FNPCCrowdLodSetting>::MoveNext(
		                &v17,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::RectInt>::MoveNext) )
		      {
		        node = (RectInt)v17._current;
		        HG::Rendering::Runtime::AtlasMaxRect::_PlaceFreeRect(v4, &node, 0LL);
		        m_usedRectangles = v4->fields.m_usedRectangles;
		        m_XMin = node.m_XMin;
		        m_YMin = node.m_YMin;
		        if ( !m_usedRectangles )
		          sub_1800D8250(0LL, v7);
		        if ( System::Collections::Generic::Dictionary<System::ValueTuple<int,int>,UnityEngine::RectInt>::Remove(
		               m_usedRectangles,
		               *(ValueTuple_2_Int32_Int32_ *)&node.m_XMin,
		               MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<int,int>,UnityEngine::RectInt>::Remove) )
		        {
		          v4->fields.m_usedRectSize -= node.m_Width * node.m_Height;
		        }
		        else
		        {
		          HG::Rendering::HGRPLogger::LogError<int,int,int,int>(
		            (String *)"Trying to remove a rectangle that has not been inserted:  (x,y)=({0},{1}) (w,h)=({2},{3})",
		            m_XMin,
		            m_YMin,
		            node.m_Width,
		            node.m_Height,
		            MethodInfo::HG::Rendering::HGRPLogger::LogError<int,int,int,int>);
		        }
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v14 )
		    {
		      v16._list = (List_1_Beyond_NPC_Animation_NPCCrowdLodSettingConfig_FNPCCrowdLodSetting_ *)v14->ex;
		      if ( v16._list )
		        sub_18007E1E0(v16._list);
		      v4 = this;
		    }
		    HG::Rendering::Runtime::AtlasMaxRect::_RecalculateMaxFreeRectWidthHeight(v4, 0LL);
		  }
		}
		
		public void Reset() {} // 0x000000018425F2B0-0x000000018425F350
		// Void Reset()
		void HG::Rendering::Runtime::AtlasMaxRect::Reset(AtlasMaxRect *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *m_usedRectangles; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  _QWORD v6[3]; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1618, 0LL) )
		  {
		    m_usedRectangles = (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)this->fields.m_usedRectangles;
		    this->fields.m_maxFreeRectWidth = this->fields.m_binWidth;
		    this->fields.m_maxFreeRectHeight = this->fields.m_binHeight;
		    this->fields.m_usedRectSize = 0;
		    if ( m_usedRectangles )
		    {
		      System::Collections::Generic::Dictionary<Beyond::Gameplay::WorldSetting::MissionImportanceAndType,System::Object>::Clear(
		        m_usedRectangles,
		        MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<int,int>,UnityEngine::RectInt>::Clear);
		      m_usedRectangles = (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)this->fields.m_freeRectangles;
		      if ( m_usedRectangles )
		      {
		        ++HIDWORD(m_usedRectangles->fields._entries);
		        LODWORD(m_usedRectangles->fields._entries) = 0;
		        m_usedRectangles = (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)this->fields.m_freeRectangles;
		        v6[1] = *(_QWORD *)&this->fields.m_binWidth;
		        v6[0] = 0LL;
		        if ( m_usedRectangles )
		        {
		          sub_184565900(m_usedRectangles, v6, MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::Add);
		          return;
		        }
		      }
		    }
		LABEL_6:
		    sub_1800D8260(m_usedRectangles, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1618, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private void _PlaceRect([IsReadOnly] in RectInt node) {} // 0x0000000189B709DC-0x0000000189B70B60
		// Void _PlaceRect(RectInt ByRef)
		void HG::Rendering::Runtime::AtlasMaxRect::_PlaceRect(AtlasMaxRect *this, RectInt *node, MethodInfo *method)
		{
		  List_1_UnityEngine_RectInt_ *v5; // rdx
		  Dictionary_2_System_ValueTuple_2_Int32_Int32_UnityEngine_RectInt_ *m_usedRectangles; // rcx
		  int32_t v7; // edi
		  List_1_UnityEngine_RectInt_ *m_freeRectangles; // rax
		  List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *v9; // r14
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  RectInt freeNode; // [rsp+20h] [rbp-40h] BYREF
		  RectInt v12; // [rsp+30h] [rbp-30h] BYREF
		  RectInt v13; // [rsp+40h] [rbp-20h] BYREF
		  RectInt v14; // [rsp+50h] [rbp-10h] BYREF
		  ValueTuple_2_Int32_Int32_ v15; // [rsp+98h] [rbp+38h]
		
		  freeNode = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(1634, 0LL) )
		  {
		    v7 = 0;
		    while ( 1 )
		    {
		      m_freeRectangles = this->fields.m_freeRectangles;
		      if ( !m_freeRectangles )
		        goto LABEL_13;
		      if ( v7 >= m_freeRectangles->fields._size )
		        break;
		      System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		        (ObjectTranslator_LuaCSFunctionPtr *)&v12,
		        (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_freeRectangles,
		        v7,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		      freeNode = v12;
		      if ( HG::Rendering::Runtime::AtlasMaxRect::_SplitFreeNode(this, &freeNode, node, 0LL) )
		      {
		        v9 = (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_freeRectangles;
		        v5 = (List_1_UnityEngine_RectInt_ *)v9;
		        if ( !v9 )
		          goto LABEL_13;
		        System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		          (ObjectTranslator_LuaCSFunctionPtr *)&v13,
		          v9,
		          v9->fields._size - 1,
		          MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		        v14 = v13;
		        System::Collections::Generic::List<Beyond::NPC::Animation::NPCCrowdLodSettingConfig::FNPCCrowdLodSetting>::set_Item(
		          (List_1_Beyond_NPC_Animation_NPCCrowdLodSettingConfig_FNPCCrowdLodSetting_ *)v9,
		          v7,
		          (NPCCrowdLodSettingConfig_FNPCCrowdLodSetting *)&v14,
		          MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::set_Item);
		        v5 = this->fields.m_freeRectangles;
		        if ( !v5 )
		          goto LABEL_13;
		        System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::RemoveAt(
		          (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)this->fields.m_freeRectangles,
		          v5->fields._size - 1,
		          MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::RemoveAt);
		      }
		      else
		      {
		        ++v7;
		      }
		    }
		    HG::Rendering::Runtime::AtlasMaxRect::_PruneFreeList(this, 0LL);
		    m_usedRectangles = this->fields.m_usedRectangles;
		    freeNode = *node;
		    v15 = (ValueTuple_2_Int32_Int32_)__PAIR64__(freeNode.m_YMin, _mm_cvtsi128_si32((__m128i)freeNode));
		    if ( m_usedRectangles )
		    {
		      v14 = freeNode;
		      System::Collections::Generic::Dictionary<System::ValueTuple<int,int>,UnityEngine::RectInt>::Add(
		        m_usedRectangles,
		        v15,
		        &v14,
		        MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<int,int>,UnityEngine::RectInt>::Add);
		      this->fields.m_usedRectSize += *(_QWORD *)&node->m_Width * HIDWORD(*(_QWORD *)&node->m_Width);
		      return;
		    }
		LABEL_13:
		    sub_1800D8260(m_usedRectangles, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1634, 0LL);
		  if ( !Patch )
		    goto LABEL_13;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_656(Patch, (Object *)this, node, 0LL);
		}
		
		private RectInt _ScoreRect(int width, int height, FreeRectChoiceHeuristic method, out int score1, out int score2) {
			score1 = default;
			score2 = default;
			return default;
		} // 0x0000000189B70EBC-0x0000000189B710A4
		// RectInt _ScoreRect(Int32, Int32, AtlasMaxRect+FreeRectChoiceHeuristic, Int32 ByRef, Int32 ByRef)
		RectInt *HG::Rendering::Runtime::AtlasMaxRect::_ScoreRect(
		        RectInt *__return_ptr retstr,
		        AtlasMaxRect *this,
		        int32_t width,
		        int32_t height,
		        AtlasMaxRect_FreeRectChoiceHeuristic__Enum method_1,
		        int32_t *score1,
		        int32_t *score2,
		        MethodInfo *method)
		{
		  __m128i v12; // xmm1
		  RectInt *PositionForNewNodeBestLongSideFit; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v15; // rcx
		  RectInt v17; // [rsp+50h] [rbp-28h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2752, 0LL) )
		  {
		    v12 = 0LL;
		    *score1 = 0x7FFFFFFF;
		    *score2 = 0x7FFFFFFF;
		    if ( method_1 )
		    {
		      if ( method_1 == AtlasMaxRect_FreeRectChoiceHeuristic__Enum_RectBestLongSideFit )
		      {
		        PositionForNewNodeBestLongSideFit = HG::Rendering::Runtime::AtlasMaxRect::_FindPositionForNewNodeBestLongSideFit(
		                                              &v17,
		                                              this,
		                                              width,
		                                              height,
		                                              score2,
		                                              score1,
		                                              0LL);
		      }
		      else if ( method_1 == AtlasMaxRect_FreeRectChoiceHeuristic__Enum_RectBestAreaFit )
		      {
		        PositionForNewNodeBestLongSideFit = HG::Rendering::Runtime::AtlasMaxRect::_FindPositionForNewNodeBestAreaFit(
		                                              &v17,
		                                              this,
		                                              width,
		                                              height,
		                                              score1,
		                                              score2,
		                                              0LL);
		      }
		      else
		      {
		        if ( method_1 != AtlasMaxRect_FreeRectChoiceHeuristic__Enum_RectBottomLeftRule )
		        {
		          if ( method_1 == AtlasMaxRect_FreeRectChoiceHeuristic__Enum_RectContactPointRule )
		          {
		            v12 = *(__m128i *)HG::Rendering::Runtime::AtlasMaxRect::_FindPositionForNewNodeContactPoint(
		                                &v17,
		                                this,
		                                width,
		                                height,
		                                score1,
		                                0LL);
		            *score1 = -*score1;
		          }
		          goto LABEL_13;
		        }
		        PositionForNewNodeBestLongSideFit = HG::Rendering::Runtime::AtlasMaxRect::_FindPositionForNewNodeBottomLeft(
		                                              &v17,
		                                              this,
		                                              width,
		                                              height,
		                                              score1,
		                                              score2,
		                                              0LL);
		      }
		    }
		    else
		    {
		      PositionForNewNodeBestLongSideFit = HG::Rendering::Runtime::AtlasMaxRect::_FindPositionForNewNodeBestShortSideFit(
		                                            &v17,
		                                            this,
		                                            width,
		                                            height,
		                                            score1,
		                                            score2,
		                                            0LL);
		    }
		    v12 = *(__m128i *)PositionForNewNodeBestLongSideFit;
		LABEL_13:
		    if ( !_mm_srli_si128(v12, 8).m128i_u32[1] )
		    {
		      *score1 = 0x7FFFFFFF;
		      *score2 = 0x7FFFFFFF;
		    }
		    *retstr = (RectInt)v12;
		    return retstr;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2752, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v15, 0LL);
		  *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1004(
		               &v17,
		               Patch,
		               (Object *)this,
		               width,
		               height,
		               method_1,
		               score1,
		               score2,
		               0LL);
		  return retstr;
		}
		
		private bool _SplitFreeNode([IsReadOnly] in RectInt freeNode, [IsReadOnly] in RectInt usedNode) => default; // 0x0000000189B710A4-0x0000000189B7136C
		// Boolean _SplitFreeNode(RectInt ByRef, RectInt ByRef)
		bool HG::Rendering::Runtime::AtlasMaxRect::_SplitFreeNode(
		        AtlasMaxRect *this,
		        RectInt *freeNode,
		        RectInt *usedNode,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  List_1_UnityEngine_RectInt_ *m_newFreeRectangles; // rax
		  __int64 v11; // rdx
		  RectInt v12; // xmm0
		  __int64 v13; // rdx
		  __int64 v14; // r8
		  __int64 v15; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  int32_t newFreeRectanglesLastSize; // [rsp+30h] [rbp-20h] BYREF
		  RectInt newFreeRect; // [rsp+38h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1635, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1635, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_653(Patch, (Object *)this, freeNode, usedNode, 0LL);
		LABEL_24:
		    sub_1800D8260(v9, v8);
		  }
		  v7 = *(_QWORD *)&usedNode->m_XMin;
		  if ( (int)*(_QWORD *)&usedNode->m_XMin >= (int)(*(_QWORD *)&freeNode->m_Width + *(_QWORD *)&freeNode->m_XMin) )
		    return 0;
		  if ( (int)(v7 + *(_QWORD *)&usedNode->m_Width) <= (int)*(_QWORD *)&freeNode->m_XMin )
		    return 0;
		  if ( SHIDWORD(v7) >= (int)(HIDWORD(*(_QWORD *)&freeNode->m_XMin) + HIDWORD(*(_QWORD *)&freeNode->m_Width)) )
		    return 0;
		  v8 = HIDWORD(*(_QWORD *)&usedNode->m_XMin);
		  v9 = HIDWORD(*(_QWORD *)&freeNode->m_XMin);
		  if ( (int)(v8 + HIDWORD(*(_QWORD *)&usedNode->m_Width)) <= (int)v9 )
		    return 0;
		  m_newFreeRectangles = this->fields.m_newFreeRectangles;
		  if ( !m_newFreeRectangles )
		    goto LABEL_24;
		  newFreeRectanglesLastSize = m_newFreeRectangles->fields._size;
		  v11 = *(_QWORD *)&usedNode->m_XMin;
		  if ( (int)*(_QWORD *)&usedNode->m_XMin < (int)(*(_QWORD *)&freeNode->m_Width + *(_QWORD *)&freeNode->m_XMin)
		    && (int)(v11 + *(_QWORD *)&usedNode->m_Width) > (int)*(_QWORD *)&freeNode->m_XMin )
		  {
		    if ( SHIDWORD(v11) > (int)HIDWORD(*(_QWORD *)&freeNode->m_XMin)
		      && SHIDWORD(v11) < (int)(HIDWORD(*(_QWORD *)&freeNode->m_XMin) + HIDWORD(*(_QWORD *)&freeNode->m_Width)) )
		    {
		      newFreeRect = *freeNode;
		      newFreeRect.m_Height = HIDWORD(*(_QWORD *)&usedNode->m_XMin) - newFreeRect.m_YMin;
		      HG::Rendering::Runtime::AtlasMaxRect::_InsertNewFreeRectangle(this, &newFreeRect, &newFreeRectanglesLastSize, 0LL);
		    }
		    if ( (int)(HIDWORD(*(_QWORD *)&usedNode->m_Width) + HIDWORD(*(_QWORD *)&usedNode->m_XMin)) < (int)(HIDWORD(*(_QWORD *)&freeNode->m_XMin) + HIDWORD(*(_QWORD *)&freeNode->m_Width)) )
		    {
		      newFreeRect = *freeNode;
		      newFreeRect.m_YMin = HIDWORD(*(_QWORD *)&usedNode->m_XMin) + HIDWORD(*(_QWORD *)&usedNode->m_Width);
		      newFreeRect.m_Height = HIDWORD(*(_QWORD *)&freeNode->m_XMin)
		                           + HIDWORD(*(_QWORD *)&freeNode->m_Width)
		                           - HIDWORD(*(_QWORD *)&usedNode->m_Width)
		                           - HIDWORD(*(_QWORD *)&usedNode->m_XMin);
		      HG::Rendering::Runtime::AtlasMaxRect::_InsertNewFreeRectangle(this, &newFreeRect, &newFreeRectanglesLastSize, 0LL);
		    }
		  }
		  if ( (int)HIDWORD(*(_QWORD *)&usedNode->m_XMin) < (int)(HIDWORD(*(_QWORD *)&freeNode->m_XMin)
		                                                        + HIDWORD(*(_QWORD *)&freeNode->m_Width)) )
		  {
		    v12 = *freeNode;
		    if ( (int)(HIDWORD(*(_QWORD *)&usedNode->m_Width) + HIDWORD(*(_QWORD *)&usedNode->m_XMin)) > (int)HIDWORD(*(_QWORD *)&freeNode->m_XMin) )
		    {
		      if ( (int)*(_QWORD *)&usedNode->m_XMin > v12.m_XMin )
		      {
		        v13 = *(_QWORD *)&usedNode->m_XMin;
		        if ( (int)*(_QWORD *)&usedNode->m_XMin < (int)(*(_QWORD *)&freeNode->m_Width + v12.m_XMin) )
		        {
		          newFreeRect = *freeNode;
		          newFreeRect.m_Width = v13 - _mm_cvtsi128_si32((__m128i)v12);
		          HG::Rendering::Runtime::AtlasMaxRect::_InsertNewFreeRectangle(
		            this,
		            &newFreeRect,
		            &newFreeRectanglesLastSize,
		            0LL);
		        }
		      }
		      v14 = *(_QWORD *)&usedNode->m_XMin;
		      v15 = *(_QWORD *)&usedNode->m_Width;
		      if ( (int)(v15 + *(_QWORD *)&usedNode->m_XMin) < (int)(*(_QWORD *)&freeNode->m_Width + *(_OWORD *)freeNode) )
		      {
		        newFreeRect = *freeNode;
		        newFreeRect.m_XMin = v15 + v14;
		        newFreeRect.m_Width = *(_QWORD *)&freeNode->m_XMin
		                            + *(_QWORD *)&freeNode->m_Width
		                            - v15
		                            - *(_QWORD *)&usedNode->m_XMin;
		        HG::Rendering::Runtime::AtlasMaxRect::_InsertNewFreeRectangle(
		          this,
		          &newFreeRect,
		          &newFreeRectanglesLastSize,
		          0LL);
		      }
		    }
		  }
		  return 1;
		}
		
		private void _InsertNewFreeRectangle([IsReadOnly] in RectInt newFreeRect, ref int newFreeRectanglesLastSize) {} // 0x0000000189B6FEA8-0x0000000189B700A4
		// Void _InsertNewFreeRectangle(RectInt ByRef, Int32 ByRef)
		void HG::Rendering::Runtime::AtlasMaxRect::_InsertNewFreeRectangle(
		        AtlasMaxRect *this,
		        RectInt *newFreeRect,
		        int32_t *newFreeRectanglesLastSize,
		        MethodInfo *method)
		{
		  List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *m_newFreeRectangles; // rdx
		  List_1_UnityEngine_RectInt_ *v8; // rcx
		  int32_t v9; // esi
		  List_1_UnityEngine_RectInt_ *v10; // r15
		  int32_t v11; // r8d
		  List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *v12; // r15
		  int32_t v13; // r12d
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  RectInt b; // [rsp+30h] [rbp-50h] BYREF
		  RectInt v16; // [rsp+40h] [rbp-40h] BYREF
		  RectInt v17; // [rsp+50h] [rbp-30h] BYREF
		  RectInt v18; // [rsp+60h] [rbp-20h] BYREF
		  RectInt v19; // [rsp+70h] [rbp-10h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1636, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1636, 0LL);
		    if ( !Patch )
		      goto LABEL_16;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_658(Patch, (Object *)this, newFreeRect, newFreeRectanglesLastSize, 0LL);
		  }
		  else
		  {
		    v9 = 0;
		    if ( *newFreeRectanglesLastSize > 0 )
		    {
		      while ( 1 )
		      {
		        m_newFreeRectangles = (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_newFreeRectangles;
		        if ( !m_newFreeRectangles )
		          break;
		        System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		          (ObjectTranslator_LuaCSFunctionPtr *)&v16,
		          m_newFreeRectangles,
		          v9,
		          MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		        b = v16;
		        if ( HG::Rendering::Runtime::AtlasMaxRect::_IsContainedIn(this, newFreeRect, &b, 0LL) )
		          return;
		        m_newFreeRectangles = (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_newFreeRectangles;
		        if ( !m_newFreeRectangles )
		          break;
		        System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		          (ObjectTranslator_LuaCSFunctionPtr *)&v17,
		          m_newFreeRectangles,
		          v9,
		          MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		        b = v17;
		        if ( HG::Rendering::Runtime::AtlasMaxRect::_IsContainedIn(this, &b, newFreeRect, 0LL) )
		        {
		          v10 = this->fields.m_newFreeRectangles;
		          m_newFreeRectangles = (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)v10;
		          v11 = *newFreeRectanglesLastSize - 1;
		          *newFreeRectanglesLastSize = v11;
		          if ( !v10 )
		            break;
		          System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		            (ObjectTranslator_LuaCSFunctionPtr *)&v18,
		            (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)v10,
		            v11,
		            MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		          b = v18;
		          System::Collections::Generic::List<Beyond::NPC::Animation::NPCCrowdLodSettingConfig::FNPCCrowdLodSetting>::set_Item(
		            (List_1_Beyond_NPC_Animation_NPCCrowdLodSettingConfig_FNPCCrowdLodSetting_ *)v10,
		            v9,
		            (NPCCrowdLodSettingConfig_FNPCCrowdLodSetting *)&b,
		            MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::set_Item);
		          v12 = (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_newFreeRectangles;
		          v13 = *newFreeRectanglesLastSize;
		          m_newFreeRectangles = v12;
		          if ( !v12 )
		            break;
		          System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		            (ObjectTranslator_LuaCSFunctionPtr *)&v19,
		            v12,
		            v12->fields._size - 1,
		            MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		          b = v19;
		          System::Collections::Generic::List<Beyond::NPC::Animation::NPCCrowdLodSettingConfig::FNPCCrowdLodSetting>::set_Item(
		            (List_1_Beyond_NPC_Animation_NPCCrowdLodSettingConfig_FNPCCrowdLodSetting_ *)v12,
		            v13,
		            (NPCCrowdLodSettingConfig_FNPCCrowdLodSetting *)&b,
		            MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::set_Item);
		          m_newFreeRectangles = (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_newFreeRectangles;
		          if ( !m_newFreeRectangles )
		            break;
		          System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::RemoveAt(
		            (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)this->fields.m_newFreeRectangles,
		            m_newFreeRectangles->fields._size - 1,
		            MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::RemoveAt);
		        }
		        else
		        {
		          ++v9;
		        }
		        if ( v9 >= *newFreeRectanglesLastSize )
		          goto LABEL_13;
		      }
		LABEL_16:
		      sub_1800D8260(v8, m_newFreeRectangles);
		    }
		LABEL_13:
		    v8 = this->fields.m_newFreeRectangles;
		    if ( !v8 )
		      goto LABEL_16;
		    v19 = *newFreeRect;
		    sub_184565900(v8, &v19, MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::Add);
		  }
		}
		
		private void _PruneFreeList() {} // 0x0000000189B70B60-0x0000000189B70DF0
		// Void _PruneFreeList()
		void HG::Rendering::Runtime::AtlasMaxRect::_PruneFreeList(AtlasMaxRect *this, MethodInfo *method)
		{
		  List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *v3; // rdx
		  List_1_UnityEngine_RectInt_ *m_newFreeRectangles; // rcx
		  int32_t i; // edi
		  List_1_UnityEngine_RectInt_ *m_freeRectangles; // rax
		  int32_t j; // esi
		  List_1_UnityEngine_RectInt_ *v8; // rax
		  List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *v9; // rsi
		  int32_t v10; // r14d
		  List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *v11; // r14
		  int32_t v12; // r15d
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  RectInt b; // [rsp+28h] [rbp-39h] BYREF
		  RectInt a; // [rsp+38h] [rbp-29h] BYREF
		  RectInt v16; // [rsp+48h] [rbp-19h] BYREF
		  RectInt v17; // [rsp+58h] [rbp-9h] BYREF
		  RectInt v18; // [rsp+68h] [rbp+7h] BYREF
		  RectInt v19; // [rsp+78h] [rbp+17h] BYREF
		  RectInt v20; // [rsp+88h] [rbp+27h] BYREF
		  RectInt v21; // [rsp+98h] [rbp+37h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1637, 0LL) )
		  {
		    for ( i = 0; ; ++i )
		    {
		      m_freeRectangles = this->fields.m_freeRectangles;
		      if ( !m_freeRectangles )
		        goto LABEL_24;
		      if ( i >= m_freeRectangles->fields._size )
		      {
		        System::Collections::Generic::List<UnityEngine::RectInt>::AddRange(
		          this->fields.m_freeRectangles,
		          (IEnumerable_1_UnityEngine_RectInt_ *)this->fields.m_newFreeRectangles,
		          MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::AddRange);
		        m_newFreeRectangles = this->fields.m_newFreeRectangles;
		        if ( m_newFreeRectangles )
		        {
		          ++m_newFreeRectangles->fields._version;
		          m_newFreeRectangles->fields._size = 0;
		          HG::Rendering::Runtime::AtlasMaxRect::_RecalculateMaxFreeRectWidthHeight(this, 0LL);
		          return;
		        }
		LABEL_24:
		        sub_1800D8260(m_newFreeRectangles, v3);
		      }
		      for ( j = 0; ; ++j )
		      {
		        v8 = this->fields.m_newFreeRectangles;
		        if ( !v8 )
		          goto LABEL_24;
		        if ( j >= v8->fields._size )
		          goto LABEL_16;
		        System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		          (ObjectTranslator_LuaCSFunctionPtr *)&v16,
		          (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_newFreeRectangles,
		          j,
		          MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		        v3 = (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_freeRectangles;
		        a = v16;
		        if ( !v3 )
		          goto LABEL_24;
		        System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		          (ObjectTranslator_LuaCSFunctionPtr *)&v17,
		          v3,
		          i,
		          MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		        b = v17;
		        if ( !HG::Rendering::Runtime::AtlasMaxRect::_IsContainedIn(this, &a, &b, 0LL) )
		          break;
		        v11 = (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_newFreeRectangles;
		        v12 = j--;
		        v3 = v11;
		        if ( !v11 )
		          goto LABEL_24;
		        System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		          (ObjectTranslator_LuaCSFunctionPtr *)&v20,
		          v11,
		          v11->fields._size - 1,
		          MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		        a = v20;
		        System::Collections::Generic::List<Beyond::NPC::Animation::NPCCrowdLodSettingConfig::FNPCCrowdLodSetting>::set_Item(
		          (List_1_Beyond_NPC_Animation_NPCCrowdLodSettingConfig_FNPCCrowdLodSetting_ *)v11,
		          v12,
		          (NPCCrowdLodSettingConfig_FNPCCrowdLodSetting *)&a,
		          MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::set_Item);
		        v3 = (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_newFreeRectangles;
		        if ( !v3 )
		          goto LABEL_24;
		        System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::RemoveAt(
		          (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)this->fields.m_newFreeRectangles,
		          v3->fields._size - 1,
		          MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::RemoveAt);
		LABEL_20:
		        ;
		      }
		      v3 = (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_freeRectangles;
		      if ( !v3 )
		        goto LABEL_24;
		      System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		        (ObjectTranslator_LuaCSFunctionPtr *)&v18,
		        v3,
		        i,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		      v3 = (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_newFreeRectangles;
		      a = v18;
		      if ( !v3 )
		        goto LABEL_24;
		      System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		        (ObjectTranslator_LuaCSFunctionPtr *)&v19,
		        v3,
		        j,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		      b = v19;
		      if ( !HG::Rendering::Runtime::AtlasMaxRect::_IsContainedIn(this, &a, &b, 0LL) )
		        goto LABEL_20;
		      v9 = (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_freeRectangles;
		      v10 = i--;
		      v3 = v9;
		      if ( !v9 )
		        goto LABEL_24;
		      System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		        (ObjectTranslator_LuaCSFunctionPtr *)&v21,
		        v9,
		        v9->fields._size - 1,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		      a = v21;
		      System::Collections::Generic::List<Beyond::NPC::Animation::NPCCrowdLodSettingConfig::FNPCCrowdLodSetting>::set_Item(
		        (List_1_Beyond_NPC_Animation_NPCCrowdLodSettingConfig_FNPCCrowdLodSetting_ *)v9,
		        v10,
		        (NPCCrowdLodSettingConfig_FNPCCrowdLodSetting *)&a,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::set_Item);
		      v3 = (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_freeRectangles;
		      if ( !v3 )
		        goto LABEL_24;
		      System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::RemoveAt(
		        (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)this->fields.m_freeRectangles,
		        v3->fields._size - 1,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::RemoveAt);
		LABEL_16:
		      ;
		    }
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1637, 0LL);
		  if ( !Patch )
		    goto LABEL_24;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private void _RecalculateMaxFreeRectWidthHeight() {} // 0x0000000189B70DF0-0x0000000189B70EBC
		// Void _RecalculateMaxFreeRectWidthHeight()
		void HG::Rendering::Runtime::AtlasMaxRect::_RecalculateMaxFreeRectWidthHeight(AtlasMaxRect *this, MethodInfo *method)
		{
		  List_1_UnityEngine_RectInt_ *v3; // rdx
		  __int64 v4; // rcx
		  int32_t i; // esi
		  List_1_UnityEngine_RectInt_ *m_freeRectangles; // rax
		  int m_maxFreeRectWidth; // ebx
		  int m_maxFreeRectHeight; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ObjectTranslator_LuaCSFunctionPtr v10; // [rsp+20h] [rbp-28h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1627, 0LL) )
		  {
		    this->fields.m_maxFreeRectWidth = 0;
		    this->fields.m_maxFreeRectHeight = 0;
		    for ( i = 0; ; ++i )
		    {
		      m_freeRectangles = this->fields.m_freeRectangles;
		      if ( !m_freeRectangles )
		        break;
		      if ( i >= m_freeRectangles->fields._size )
		        return;
		      m_maxFreeRectWidth = this->fields.m_maxFreeRectWidth;
		      System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		        &v10,
		        (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_freeRectangles,
		        i,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		      v3 = this->fields.m_freeRectangles;
		      if ( m_maxFreeRectWidth <= SLODWORD(v10.target) )
		        m_maxFreeRectWidth = (int)v10.target;
		      this->fields.m_maxFreeRectWidth = m_maxFreeRectWidth;
		      m_maxFreeRectHeight = this->fields.m_maxFreeRectHeight;
		      if ( !v3 )
		        break;
		      System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		        &v11,
		        (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)v3,
		        i,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		      if ( m_maxFreeRectHeight <= SHIDWORD(v11.target) )
		        m_maxFreeRectHeight = HIDWORD(v11.target);
		      this->fields.m_maxFreeRectHeight = m_maxFreeRectHeight;
		    }
		LABEL_12:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1627, 0LL);
		  if ( !Patch )
		    goto LABEL_12;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private void _PlaceFreeRect([IsReadOnly] in RectInt node) {} // 0x0000000189B705E0-0x0000000189B709DC
		// Void _PlaceFreeRect(RectInt ByRef)
		void HG::Rendering::Runtime::AtlasMaxRect::_PlaceFreeRect(AtlasMaxRect *this, RectInt *node, MethodInfo *method)
		{
		  __int64 v5; // rdx
		  List_1_UnityEngine_RectInt_ *v6; // rcx
		  int32_t v7; // r14d
		  List_1_UnityEngine_RectInt_ *m_freeRectangles; // rax
		  int32_t xMin; // ebx
		  int32_t v10; // ebx
		  int32_t v11; // ebx
		  int32_t v12; // ebx
		  int32_t v13; // eax
		  int32_t xMax; // ebx
		  int32_t v15; // ebx
		  int32_t v16; // ebx
		  int32_t v17; // ebx
		  int32_t v18; // eax
		  int32_t yMin; // ebx
		  int32_t v20; // ebx
		  int32_t v21; // ebx
		  int32_t v22; // ebx
		  int32_t v23; // eax
		  int32_t yMax; // ebx
		  int32_t v25; // ebx
		  int32_t v26; // ebx
		  int32_t v27; // ebx
		  int32_t v28; // eax
		  bool IsContainedIn; // al
		  RectInt v30; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  RectInt v32; // [rsp+20h] [rbp-50h] BYREF
		  RectInt v33; // [rsp+30h] [rbp-40h] BYREF
		  RectInt r; // [rsp+40h] [rbp-30h] BYREF
		  RectInt b; // [rsp+50h] [rbp-20h] BYREF
		  RectInt v36; // [rsp+60h] [rbp-10h] BYREF
		
		  r = 0LL;
		  b = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(1622, 0LL) )
		  {
		    v7 = 0;
		    r = *node;
		    b = r;
		    while ( 1 )
		    {
		      m_freeRectangles = this->fields.m_freeRectangles;
		      if ( !m_freeRectangles )
		        goto LABEL_36;
		      if ( v7 >= m_freeRectangles->fields._size )
		        break;
		      System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		        (ObjectTranslator_LuaCSFunctionPtr *)&v36,
		        (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_freeRectangles,
		        v7,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		      v32 = *node;
		      v33 = v36;
		      xMin = UnityEngine::RectInt::get_xMin(&v32, 0LL);
		      if ( xMin == UnityEngine::RectInt::get_xMax(&v33, 0LL)
		        && (v10 = UnityEngine::RectInt::get_yMin(&v33, 0LL),
		            v32 = *node,
		            v10 <= UnityEngine::RectInt::get_yMin(&v32, 0LL))
		        && (v11 = UnityEngine::RectInt::get_yMax(&v33, 0LL),
		            v32 = *node,
		            v11 >= UnityEngine::RectInt::get_yMax(&v32, 0LL))
		        && (v12 = UnityEngine::RectInt::get_xMin(&v33, 0LL), v12 < UnityEngine::RectInt::get_xMin(&r, 0LL)) )
		      {
		        v13 = UnityEngine::RectInt::get_xMin(&v33, 0LL);
		        UnityEngine::RectInt::set_xMin(&r, v13, 0LL);
		      }
		      else
		      {
		        v32 = *node;
		        xMax = UnityEngine::RectInt::get_xMax(&v32, 0LL);
		        if ( xMax == UnityEngine::RectInt::get_xMin(&v33, 0LL)
		          && (v15 = UnityEngine::RectInt::get_yMin(&v33, 0LL),
		              v32 = *node,
		              v15 <= UnityEngine::RectInt::get_yMin(&v32, 0LL))
		          && (v16 = UnityEngine::RectInt::get_yMax(&v33, 0LL),
		              v32 = *node,
		              v16 >= UnityEngine::RectInt::get_yMax(&v32, 0LL))
		          && (v17 = UnityEngine::RectInt::get_xMax(&v33, 0LL), v17 > UnityEngine::RectInt::get_xMax(&r, 0LL)) )
		        {
		          v18 = UnityEngine::RectInt::get_xMax(&v33, 0LL);
		          r.m_Width = v18 - r.m_XMin;
		        }
		        else
		        {
		          v32 = *node;
		          yMin = UnityEngine::RectInt::get_yMin(&v32, 0LL);
		          if ( yMin == UnityEngine::RectInt::get_yMax(&v33, 0LL)
		            && (v20 = UnityEngine::RectInt::get_xMin(&v33, 0LL),
		                v32 = *node,
		                v20 <= UnityEngine::RectInt::get_xMin(&v32, 0LL))
		            && (v21 = UnityEngine::RectInt::get_xMax(&v33, 0LL),
		                v32 = *node,
		                v21 >= UnityEngine::RectInt::get_xMax(&v32, 0LL))
		            && (v22 = UnityEngine::RectInt::get_yMin(&v33, 0LL), v22 < UnityEngine::RectInt::get_yMin(&r, 0LL)) )
		          {
		            v23 = UnityEngine::RectInt::get_yMin(&v33, 0LL);
		            UnityEngine::RectInt::set_yMin(&b, v23, 0LL);
		          }
		          else
		          {
		            v32 = *node;
		            yMax = UnityEngine::RectInt::get_yMax(&v32, 0LL);
		            if ( yMax == UnityEngine::RectInt::get_yMin(&v33, 0LL) )
		            {
		              v25 = UnityEngine::RectInt::get_xMin(&v33, 0LL);
		              v32 = *node;
		              if ( v25 <= UnityEngine::RectInt::get_xMin(&v32, 0LL) )
		              {
		                v26 = UnityEngine::RectInt::get_xMax(&v33, 0LL);
		                v32 = *node;
		                if ( v26 >= UnityEngine::RectInt::get_xMax(&v32, 0LL) )
		                {
		                  v27 = UnityEngine::RectInt::get_yMax(&v33, 0LL);
		                  if ( v27 > UnityEngine::RectInt::get_yMax(&r, 0LL) )
		                  {
		                    v28 = UnityEngine::RectInt::get_yMax(&v33, 0LL);
		                    b.m_Height = v28 - b.m_YMin;
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		      ++v7;
		    }
		    HG::Rendering::Runtime::AtlasMaxRect::_MergeFreeRect(this, &r, 0LL);
		    HG::Rendering::Runtime::AtlasMaxRect::_MergeFreeRect(this, &b, 0LL);
		    if ( !HG::Rendering::Runtime::AtlasMaxRect::_IsContainedIn(this, &r, &b, 0LL) )
		    {
		      IsContainedIn = HG::Rendering::Runtime::AtlasMaxRect::_IsContainedIn(this, &b, &r, 0LL);
		      v6 = this->fields.m_freeRectangles;
		      if ( IsContainedIn )
		      {
		        if ( v6 )
		        {
		          v30 = r;
		          goto LABEL_32;
		        }
		LABEL_36:
		        sub_1800D8260(v6, v5);
		      }
		      if ( !v6 )
		        goto LABEL_36;
		      v36 = r;
		      sub_184565900(v6, &v36, MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::Add);
		    }
		    v6 = this->fields.m_freeRectangles;
		    if ( v6 )
		    {
		      v30 = b;
		LABEL_32:
		      v36 = v30;
		      sub_184565900(v6, &v36, MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::Add);
		      return;
		    }
		    goto LABEL_36;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1622, 0LL);
		  if ( !Patch )
		    goto LABEL_36;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_656(Patch, (Object *)this, node, 0LL);
		}
		
		private void _AlignRectWidth(ref RectInt src, [IsReadOnly] in RectInt dst) {} // 0x0000000189B6EF90-0x0000000189B6F054
		// Void _AlignRectWidth(RectInt ByRef, RectInt ByRef)
		void HG::Rendering::Runtime::AtlasMaxRect::_AlignRectWidth(
		        AtlasMaxRect *this,
		        RectInt *src,
		        RectInt *dst,
		        MethodInfo *method)
		{
		  int32_t xMin; // ebx
		  int32_t v8; // eax
		  int32_t xMax; // ebx
		  int32_t v10; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  RectInt v14; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1625, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1625, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v13, v12);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_654(Patch, (Object *)this, src, dst, 0LL);
		  }
		  else
		  {
		    xMin = UnityEngine::RectInt::get_xMin(src, 0LL);
		    v14 = *dst;
		    v8 = UnityEngine::RectInt::get_xMin(&v14, 0LL);
		    if ( xMin < v8 )
		      v8 = xMin;
		    UnityEngine::RectInt::set_xMin(src, v8, 0LL);
		    xMax = UnityEngine::RectInt::get_xMax(src, 0LL);
		    v14 = *dst;
		    v10 = UnityEngine::RectInt::get_xMax(&v14, 0LL);
		    if ( xMax > v10 )
		      v10 = xMax;
		    src->m_Width = v10 - src->m_XMin;
		  }
		}
		
		private void _AlignRectHeight(ref RectInt src, [IsReadOnly] in RectInt dst) {} // 0x0000000189B6EEC8-0x0000000189B6EF90
		// Void _AlignRectHeight(RectInt ByRef, RectInt ByRef)
		void HG::Rendering::Runtime::AtlasMaxRect::_AlignRectHeight(
		        AtlasMaxRect *this,
		        RectInt *src,
		        RectInt *dst,
		        MethodInfo *method)
		{
		  int32_t yMin; // ebx
		  int32_t v8; // eax
		  int32_t yMax; // ebx
		  int32_t v10; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  RectInt v14; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1626, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1626, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v13, v12);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_654(Patch, (Object *)this, src, dst, 0LL);
		  }
		  else
		  {
		    yMin = UnityEngine::RectInt::get_yMin(src, 0LL);
		    v14 = *dst;
		    v8 = UnityEngine::RectInt::get_yMin(&v14, 0LL);
		    if ( yMin < v8 )
		      v8 = yMin;
		    UnityEngine::RectInt::set_yMin(src, v8, 0LL);
		    yMax = UnityEngine::RectInt::get_yMax(src, 0LL);
		    v14 = *dst;
		    v10 = UnityEngine::RectInt::get_yMax(&v14, 0LL);
		    if ( yMax > v10 )
		      v10 = yMax;
		    src->m_Height = v10 - src->m_YMin;
		  }
		}
		
		private void _MergeFreeRect(ref RectInt r) {} // 0x0000000189B70160-0x0000000189B705E0
		// Void _MergeFreeRect(RectInt ByRef)
		void HG::Rendering::Runtime::AtlasMaxRect::_MergeFreeRect(AtlasMaxRect *this, RectInt *r, MethodInfo *method)
		{
		  List_1_UnityEngine_RectInt_ *v5; // rdx
		  List_1_UnityEngine_RectInt_ *v6; // rcx
		  int32_t i; // r15d
		  List_1_UnityEngine_RectInt_ *m_freeRectangles; // rax
		  int32_t xMin; // ebx
		  int32_t v10; // edi
		  int32_t xMax; // ebx
		  int32_t v12; // eax
		  int32_t v13; // ebx
		  int32_t v14; // edi
		  int32_t v15; // ebx
		  int32_t v16; // eax
		  int32_t v17; // ebx
		  int32_t v18; // ebx
		  List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *v19; // rbx
		  int32_t v20; // edi
		  int32_t v21; // ebx
		  int32_t v22; // ebx
		  int32_t v23; // ebx
		  int32_t v24; // ebx
		  int32_t yMin; // ebx
		  int32_t yMax; // ebx
		  List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *v27; // rbx
		  int32_t v28; // edi
		  int32_t v29; // ebx
		  int32_t v30; // ebx
		  int32_t v31; // ebx
		  int32_t v32; // ebx
		  List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *v33; // rbx
		  int32_t v34; // edi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  RectInt a; // [rsp+20h] [rbp-60h] BYREF
		  RectInt v37; // [rsp+30h] [rbp-50h] BYREF
		  RectInt v38; // [rsp+40h] [rbp-40h] BYREF
		  RectInt v39; // [rsp+50h] [rbp-30h] BYREF
		  RectInt v40; // [rsp+60h] [rbp-20h] BYREF
		  RectInt v41; // [rsp+70h] [rbp-10h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1623, 0LL) )
		  {
		    for ( i = 0; ; ++i )
		    {
		      m_freeRectangles = this->fields.m_freeRectangles;
		      if ( !m_freeRectangles )
		        goto LABEL_45;
		      if ( i >= m_freeRectangles->fields._size )
		        return;
		      System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		        (ObjectTranslator_LuaCSFunctionPtr *)&v37,
		        (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_freeRectangles,
		        i,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		      a = v37;
		      if ( HG::Rendering::Runtime::AtlasMaxRect::_IsContainedIn(this, &a, r, 0LL) )
		      {
		        v33 = (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_freeRectangles;
		        v34 = i--;
		        v5 = (List_1_UnityEngine_RectInt_ *)v33;
		        if ( !v33 )
		          goto LABEL_45;
		        System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		          (ObjectTranslator_LuaCSFunctionPtr *)&v41,
		          v33,
		          v33->fields._size - 1,
		          MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		        v39 = v41;
		        System::Collections::Generic::List<Beyond::NPC::Animation::NPCCrowdLodSettingConfig::FNPCCrowdLodSetting>::set_Item(
		          (List_1_Beyond_NPC_Animation_NPCCrowdLodSettingConfig_FNPCCrowdLodSetting_ *)v33,
		          v34,
		          (NPCCrowdLodSettingConfig_FNPCCrowdLodSetting *)&v39,
		          MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::set_Item);
		        v5 = this->fields.m_freeRectangles;
		        if ( !v5 )
		          goto LABEL_45;
		        System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::RemoveAt(
		          (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)this->fields.m_freeRectangles,
		          v5->fields._size - 1,
		          MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::RemoveAt);
		      }
		      else
		      {
		        xMin = UnityEngine::RectInt::get_xMin(r, 0LL);
		        v10 = UnityEngine::RectInt::get_xMin(&a, 0LL);
		        if ( xMin > v10 )
		          v10 = xMin;
		        xMax = UnityEngine::RectInt::get_xMax(r, 0LL);
		        v12 = UnityEngine::RectInt::get_xMax(&a, 0LL);
		        if ( xMax < v12 )
		          v12 = xMax;
		        if ( v10 <= v12 )
		        {
		          yMin = UnityEngine::RectInt::get_yMin(&a, 0LL);
		          if ( yMin == UnityEngine::RectInt::get_yMin(r, 0LL) )
		          {
		            yMax = UnityEngine::RectInt::get_yMax(&a, 0LL);
		            if ( yMax == UnityEngine::RectInt::get_yMax(r, 0LL) )
		            {
		              v27 = (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_freeRectangles;
		              v28 = i--;
		              v5 = (List_1_UnityEngine_RectInt_ *)v27;
		              if ( !v27 )
		                goto LABEL_45;
		              System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		                (ObjectTranslator_LuaCSFunctionPtr *)&v40,
		                v27,
		                v27->fields._size - 1,
		                MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		              v39 = v40;
		              System::Collections::Generic::List<Beyond::NPC::Animation::NPCCrowdLodSettingConfig::FNPCCrowdLodSetting>::set_Item(
		                (List_1_Beyond_NPC_Animation_NPCCrowdLodSettingConfig_FNPCCrowdLodSetting_ *)v27,
		                v28,
		                (NPCCrowdLodSettingConfig_FNPCCrowdLodSetting *)&v39,
		                MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::set_Item);
		              v5 = this->fields.m_freeRectangles;
		              if ( !v5 )
		                goto LABEL_45;
		              System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::RemoveAt(
		                (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)this->fields.m_freeRectangles,
		                v5->fields._size - 1,
		                MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::RemoveAt);
		LABEL_34:
		              HG::Rendering::Runtime::AtlasMaxRect::_AlignRectWidth(this, r, &a, 0LL);
		              continue;
		            }
		          }
		          v29 = UnityEngine::RectInt::get_yMin(r, 0LL);
		          if ( v29 >= UnityEngine::RectInt::get_yMin(&a, 0LL) )
		          {
		            v30 = UnityEngine::RectInt::get_yMax(r, 0LL);
		            if ( v30 <= UnityEngine::RectInt::get_yMax(&a, 0LL) )
		              goto LABEL_34;
		          }
		          v31 = UnityEngine::RectInt::get_yMin(&a, 0LL);
		          if ( v31 >= UnityEngine::RectInt::get_yMin(r, 0LL) )
		          {
		            v32 = UnityEngine::RectInt::get_yMax(&a, 0LL);
		            if ( v32 <= UnityEngine::RectInt::get_yMax(r, 0LL) )
		            {
		              HG::Rendering::Runtime::AtlasMaxRect::_AlignRectWidth(this, &a, r, 0LL);
		              goto LABEL_27;
		            }
		          }
		        }
		        else
		        {
		          v13 = UnityEngine::RectInt::get_yMin(r, 0LL);
		          v14 = UnityEngine::RectInt::get_yMin(&a, 0LL);
		          if ( v13 > v14 )
		            v14 = v13;
		          v15 = UnityEngine::RectInt::get_yMax(r, 0LL);
		          v16 = UnityEngine::RectInt::get_yMax(&a, 0LL);
		          if ( v15 < v16 )
		            v16 = v15;
		          if ( v14 <= v16 )
		          {
		            v17 = UnityEngine::RectInt::get_xMin(&a, 0LL);
		            if ( v17 == UnityEngine::RectInt::get_xMin(r, 0LL) )
		            {
		              v18 = UnityEngine::RectInt::get_xMax(&a, 0LL);
		              if ( v18 == UnityEngine::RectInt::get_xMax(r, 0LL) )
		              {
		                v19 = (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_freeRectangles;
		                v20 = i--;
		                v5 = (List_1_UnityEngine_RectInt_ *)v19;
		                if ( !v19 )
		                  goto LABEL_45;
		                System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		                  (ObjectTranslator_LuaCSFunctionPtr *)&v38,
		                  v19,
		                  v19->fields._size - 1,
		                  MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		                v39 = v38;
		                System::Collections::Generic::List<Beyond::NPC::Animation::NPCCrowdLodSettingConfig::FNPCCrowdLodSetting>::set_Item(
		                  (List_1_Beyond_NPC_Animation_NPCCrowdLodSettingConfig_FNPCCrowdLodSetting_ *)v19,
		                  v20,
		                  (NPCCrowdLodSettingConfig_FNPCCrowdLodSetting *)&v39,
		                  MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::set_Item);
		                v5 = this->fields.m_freeRectangles;
		                if ( !v5 )
		                  goto LABEL_45;
		                System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::RemoveAt(
		                  (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)this->fields.m_freeRectangles,
		                  v5->fields._size - 1,
		                  MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::RemoveAt);
		LABEL_21:
		                HG::Rendering::Runtime::AtlasMaxRect::_AlignRectHeight(this, r, &a, 0LL);
		                continue;
		              }
		            }
		            v21 = UnityEngine::RectInt::get_xMin(r, 0LL);
		            if ( v21 >= UnityEngine::RectInt::get_xMin(&a, 0LL) )
		            {
		              v22 = UnityEngine::RectInt::get_xMax(r, 0LL);
		              if ( v22 <= UnityEngine::RectInt::get_xMax(&a, 0LL) )
		                goto LABEL_21;
		            }
		            v23 = UnityEngine::RectInt::get_xMin(&a, 0LL);
		            if ( v23 >= UnityEngine::RectInt::get_xMin(r, 0LL) )
		            {
		              v24 = UnityEngine::RectInt::get_xMax(&a, 0LL);
		              if ( v24 <= UnityEngine::RectInt::get_xMax(r, 0LL) )
		              {
		                HG::Rendering::Runtime::AtlasMaxRect::_AlignRectHeight(this, &a, r, 0LL);
		LABEL_27:
		                v6 = this->fields.m_freeRectangles;
		                if ( !v6 )
		                  goto LABEL_45;
		                v39 = a;
		                System::Collections::Generic::List<Beyond::NPC::Animation::NPCCrowdLodSettingConfig::FNPCCrowdLodSetting>::set_Item(
		                  (List_1_Beyond_NPC_Animation_NPCCrowdLodSettingConfig_FNPCCrowdLodSetting_ *)v6,
		                  i,
		                  (NPCCrowdLodSettingConfig_FNPCCrowdLodSetting *)&v39,
		                  MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::set_Item);
		                continue;
		              }
		            }
		          }
		        }
		      }
		    }
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1623, 0LL);
		  if ( !Patch )
		LABEL_45:
		    sub_1800D8260(v6, v5);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_655(Patch, (Object *)this, r, 0LL);
		}
		
		private bool _IsContainedIn([IsReadOnly] in RectInt a, [IsReadOnly] in RectInt b) => default; // 0x0000000189B700A4-0x0000000189B70160
		// Boolean _IsContainedIn(RectInt ByRef, RectInt ByRef)
		bool HG::Rendering::Runtime::AtlasMaxRect::_IsContainedIn(
		        AtlasMaxRect *this,
		        RectInt *a,
		        RectInt *b,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1624, 0LL) )
		    return (int)*(_QWORD *)&a->m_XMin >= (int)*(_QWORD *)&b->m_XMin
		        && (int)HIDWORD(*(_QWORD *)&a->m_XMin) >= (int)HIDWORD(*(_QWORD *)&b->m_XMin)
		        && (v7 = *(_QWORD *)&a->m_Width,
		            (int)(v7 + *(_QWORD *)&a->m_XMin) <= (int)(*(_QWORD *)&b->m_Width + *(_QWORD *)&b->m_XMin))
		        && (int)(HIDWORD(v7) + HIDWORD(*(_QWORD *)&a->m_XMin)) <= (int)(HIDWORD(*(_QWORD *)&b->m_XMin)
		                                                                      + HIDWORD(*(_QWORD *)&b->m_Width));
		  Patch = IFix::WrappersManagerImpl::GetPatch(1624, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v11, v10);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_653(Patch, (Object *)this, a, b, 0LL);
		}
		
		private int _CommonIntervalCount(int i1Start, int i1End, int i2Start, int i2End) => default; // 0x0000000189B6F054-0x0000000189B6F0F4
		// Int32 _CommonIntervalCount(Int32, Int32, Int32, Int32)
		int32_t HG::Rendering::Runtime::AtlasMaxRect::_CommonIntervalCount(
		        AtlasMaxRect *this,
		        int32_t i1Start,
		        int32_t i1End,
		        int32_t i2Start,
		        int32_t i2End,
		        MethodInfo *method)
		{
		  __int64 v11; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2746, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2746, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v11);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1002(Patch, (Object *)this, i1Start, i1End, i2Start, i2End, 0LL);
		  }
		  else if ( i1End < i2Start || i2End < i1Start )
		  {
		    return 0;
		  }
		  else
		  {
		    if ( i1Start <= i2Start )
		      i1Start = i2Start;
		    if ( i1End >= i2End )
		      i1End = i2End;
		    return i1End - i1Start;
		  }
		}
		
		private int _ContactPointScoreNode(int x, int y, int width, int height) => default; // 0x0000000189B6F0F4-0x0000000189B6F384
		// Int32 _ContactPointScoreNode(Int32, Int32, Int32, Int32)
		// Hidden C++ exception states: #wind=1
		int32_t HG::Rendering::Runtime::AtlasMaxRect::_ContactPointScoreNode(
		        AtlasMaxRect *this,
		        int32_t x,
		        int32_t y,
		        int32_t width,
		        int32_t height,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  int32_t v12; // ebx
		  int32_t v13; // r14d
		  __m128i v14; // xmm1
		  unsigned __int64 v15; // xmm0_8
		  int v16; // r8^4
		  unsigned __int64 v17; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  int32_t v22; // [rsp+40h] [rbp-A8h]
		  Il2CppException *ex; // [rsp+48h] [rbp-A0h]
		  Dictionary_2_TKey_TValue_Enumerator_System_UInt64_Beyond_Gameplay_Audio_AudioSceneStreamingWrapper_FPendingReverbZoneData_ v24; // [rsp+58h] [rbp-90h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_System_UInt64_Beyond_Gameplay_Audio_AudioSceneStreamingWrapper_FPendingReverbZoneData_ v25; // [rsp+88h] [rbp-60h] BYREF
		  Il2CppExceptionWrapper *v26; // [rsp+B8h] [rbp-30h] BYREF
		  __m128i v27; // [rsp+C0h] [rbp-28h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2745, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2745, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v21, v20);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1002(Patch, (Object *)this, x, y, width, height, 0LL);
		  }
		  else
		  {
		    v12 = 0;
		    v22 = 0;
		    if ( !x || x + width == this->fields.m_binWidth )
		    {
		      v13 = height;
		      v12 = height;
		      v22 = height;
		    }
		    else
		    {
		      v13 = height;
		    }
		    if ( !y || y + v13 == this->fields.m_binHeight )
		    {
		      v12 += width;
		      v22 = v12;
		    }
		    if ( !this->fields.m_usedRectangles )
		      sub_1800D8260(v11, v10);
		    System::Collections::Generic::Dictionary<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::GetEnumerator(
		      (Dictionary_2_TKey_TValue_Enumerator_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)&v25,
		      (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)this->fields.m_usedRectangles,
		      MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<int,int>,UnityEngine::RectInt>::GetEnumerator);
		    v24 = v25;
		    try
		    {
		      while ( 1 )
		      {
		        if ( !System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned long,Beyond::Gameplay::Audio::AudioSceneStreamingWrapper::FPendingReverbZoneData>::MoveNext(
		                &v24,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::ValueTuple<int,int>,UnityEngine::RectInt>::MoveNext) )
		          return v12;
		        v14 = *(__m128i *)&v24._current.key;
		        v27 = *(__m128i *)&v24._current.key;
		        v25._current.key = *(_QWORD *)&v24._current.value.transitionWidth;
		        v15 = _mm_srli_si128(*(__m128i *)&v24._current.key, 8).m128i_u64[0];
		        if ( (_DWORD)v15 == x + width )
		        {
		          v16 = *((_DWORD *)&v24._current.value.transitionWidth + 1);
		        }
		        else
		        {
		          v16 = *((_DWORD *)&v24._current.value.transitionWidth + 1);
		          if ( LODWORD(v24._current.value.transitionWidth) + (_DWORD)v15 != x )
		            goto LABEL_17;
		        }
		        v12 += HG::Rendering::Runtime::AtlasMaxRect::_CommonIntervalCount(
		                 this,
		                 SHIDWORD(v15),
		                 HIDWORD(v15) + v16,
		                 y,
		                 y + v13,
		                 0LL);
		        v22 = v12;
		        v14 = v27;
		LABEL_17:
		        v17 = _mm_srli_si128(v14, 8).m128i_u64[0];
		        if ( HIDWORD(v17) == y + v13 || HIDWORD(v17) + HIDWORD(v25._current.key) == y )
		        {
		          v12 += HG::Rendering::Runtime::AtlasMaxRect::_CommonIntervalCount(
		                   this,
		                   v17,
		                   v17 + LODWORD(v25._current.key),
		                   x,
		                   x + width,
		                   0LL);
		          v22 = v12;
		        }
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v26 )
		    {
		      ex = v26->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      return v22;
		    }
		    return v12;
		  }
		}
		
		private RectInt _FindPositionForNewNodeBestShortSideFit(int width, int height, out int bestShortSideFit, out int bestLongSideFit) {
			bestShortSideFit = default;
			bestLongSideFit = default;
			return default;
		} // 0x0000000189B6F838-0x0000000189B6FA6C
		// RectInt _FindPositionForNewNodeBestShortSideFit(Int32, Int32, Int32 ByRef, Int32 ByRef)
		RectInt *HG::Rendering::Runtime::AtlasMaxRect::_FindPositionForNewNodeBestShortSideFit(
		        RectInt *__return_ptr retstr,
		        AtlasMaxRect *this,
		        int32_t width,
		        int32_t height,
		        int32_t *bestShortSideFit,
		        int32_t *bestLongSideFit,
		        MethodInfo *method)
		{
		  int v9; // r14d
		  int v10; // esi
		  List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *Patch; // rdx
		  __int64 v12; // rcx
		  RectInt v13; // xmm6
		  int32_t v14; // ebx
		  List_1_UnityEngine_RectInt_ *m_freeRectangles; // rax
		  int32_t v16; // eax
		  int32_t v17; // r14d
		  int32_t v18; // eax
		  int32_t v19; // esi
		  __m128i v21; // [rsp+48h] [rbp-71h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v22; // [rsp+58h] [rbp-61h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v23; // [rsp+68h] [rbp-51h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v24; // [rsp+78h] [rbp-41h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v25; // [rsp+88h] [rbp-31h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v26; // [rsp+98h] [rbp-21h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v27; // [rsp+A8h] [rbp-11h] BYREF
		
		  v9 = height;
		  v10 = width;
		  if ( !IFix::WrappersManagerImpl::IsPatched(2742, 0LL) )
		  {
		    v13 = 0LL;
		    v21 = 0LL;
		    v14 = 0;
		    *bestShortSideFit = 0x7FFFFFFF;
		    *bestLongSideFit = 0x7FFFFFFF;
		    while ( 1 )
		    {
		      m_freeRectangles = this->fields.m_freeRectangles;
		      if ( !m_freeRectangles )
		        goto LABEL_24;
		      if ( v14 >= m_freeRectangles->fields._size )
		      {
		        *retstr = v13;
		        return retstr;
		      }
		      System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		        &v22,
		        (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_freeRectangles,
		        v14,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		      if ( SLODWORD(v22.target) >= v10 )
		      {
		        Patch = (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_freeRectangles;
		        if ( !Patch )
		          goto LABEL_24;
		        System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		          &v23,
		          Patch,
		          v14,
		          MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		        if ( SHIDWORD(v23.target) >= v9 )
		          break;
		      }
		LABEL_21:
		      ++v14;
		    }
		    Patch = (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_freeRectangles;
		    if ( !Patch )
		      goto LABEL_24;
		    System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		      &v24,
		      Patch,
		      v14,
		      MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		    v16 = sub_1833FD1B0((unsigned int)(LODWORD(v24.target) - v10));
		    Patch = (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_freeRectangles;
		    v17 = v16;
		    if ( !Patch )
		      goto LABEL_24;
		    System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		      &v25,
		      Patch,
		      v14,
		      MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		    v18 = sub_1833FD1B0((unsigned int)(HIDWORD(v25.target) - height));
		    if ( v17 >= v18 )
		    {
		      v19 = v18;
		      if ( v17 > v18 )
		        goto LABEL_14;
		    }
		    else
		    {
		      v19 = v17;
		    }
		    v17 = v18;
		LABEL_14:
		    if ( v19 < *bestShortSideFit || v19 == *bestShortSideFit && v17 < *bestLongSideFit )
		    {
		      Patch = (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_freeRectangles;
		      if ( !Patch )
		        goto LABEL_24;
		      System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		        &v26,
		        Patch,
		        v14,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		      Patch = (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_freeRectangles;
		      v21.m128i_i32[0] = (__int32)v26.ptr;
		      if ( !Patch )
		        goto LABEL_24;
		      System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		        &v27,
		        Patch,
		        v14,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		      *(__int64 *)((char *)v21.m128i_i64 + 4) = __PAIR64__(width, HIDWORD(v27.ptr));
		      v21.m128i_i32[3] = height;
		      v13 = (RectInt)_mm_loadu_si128(&v21);
		      *bestShortSideFit = v19;
		      *bestLongSideFit = v17;
		    }
		    v10 = width;
		    v9 = height;
		    goto LABEL_21;
		  }
		  Patch = (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)IFix::WrappersManagerImpl::GetPatch(2742, 0LL);
		  if ( !Patch )
		LABEL_24:
		    sub_1800D8260(v12, Patch);
		  *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1001(
		               (RectInt *)&v27,
		               (ILFixDynamicMethodWrapper_2 *)Patch,
		               (Object *)this,
		               v10,
		               v9,
		               bestShortSideFit,
		               bestLongSideFit,
		               0LL);
		  return retstr;
		}
		
		private RectInt _FindPositionForNewNodeBottomLeft(int width, int height, out int bestY, out int bestX) {
			bestY = default;
			bestX = default;
			return default;
		} // 0x0000000189B6FA6C-0x0000000189B6FCA8
		// RectInt _FindPositionForNewNodeBottomLeft(Int32, Int32, Int32 ByRef, Int32 ByRef)
		RectInt *HG::Rendering::Runtime::AtlasMaxRect::_FindPositionForNewNodeBottomLeft(
		        RectInt *__return_ptr retstr,
		        AtlasMaxRect *this,
		        int32_t width,
		        int32_t height,
		        int32_t *bestY,
		        int32_t *bestX,
		        MethodInfo *method)
		{
		  int v10; // esi
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v12; // rcx
		  RectInt v13; // xmm6
		  int32_t v14; // ebx
		  List_1_UnityEngine_RectInt_ *m_freeRectangles; // rax
		  int32_t v16; // esi
		  unsigned __int64 v17; // rax
		  __m128i v19; // [rsp+48h] [rbp-71h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v20; // [rsp+58h] [rbp-61h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v21; // [rsp+68h] [rbp-51h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v22; // [rsp+78h] [rbp-41h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v23; // [rsp+88h] [rbp-31h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v24; // [rsp+98h] [rbp-21h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v25; // [rsp+A8h] [rbp-11h] BYREF
		  RectInt v26[2]; // [rsp+B8h] [rbp-1h] BYREF
		
		  v10 = width;
		  if ( IFix::WrappersManagerImpl::IsPatched(2753, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2753, 0LL);
		    if ( !Patch )
		LABEL_21:
		      sub_1800D8260(v12, Patch);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1001(
		                 v26,
		                 Patch,
		                 (Object *)this,
		                 v10,
		                 height,
		                 bestY,
		                 bestX,
		                 0LL);
		  }
		  else
		  {
		    v13 = 0LL;
		    v19 = 0LL;
		    v14 = 0;
		    *bestY = 0x7FFFFFFF;
		    *bestX = 0x7FFFFFFF;
		    while ( 1 )
		    {
		      m_freeRectangles = this->fields.m_freeRectangles;
		      if ( !m_freeRectangles )
		        goto LABEL_21;
		      if ( v14 >= m_freeRectangles->fields._size )
		        break;
		      System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		        &v20,
		        (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_freeRectangles,
		        v14,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		      if ( SLODWORD(v20.target) >= v10 )
		      {
		        Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_freeRectangles;
		        if ( !Patch )
		          goto LABEL_21;
		        System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		          &v21,
		          (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)Patch,
		          v14,
		          MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		        if ( SHIDWORD(v21.target) >= height )
		        {
		          Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_freeRectangles;
		          if ( !Patch )
		            goto LABEL_21;
		          System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		            &v22,
		            (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)Patch,
		            v14,
		            MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		          v16 = height + HIDWORD(v22.ptr);
		          if ( height + HIDWORD(v22.ptr) < *bestY )
		            goto LABEL_13;
		          if ( v16 == *bestY )
		          {
		            Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_freeRectangles;
		            if ( !Patch )
		              goto LABEL_21;
		            System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		              &v23,
		              (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)Patch,
		              v14,
		              MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		            if ( SLODWORD(v23.ptr) < *bestX )
		            {
		LABEL_13:
		              Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_freeRectangles;
		              if ( !Patch )
		                goto LABEL_21;
		              System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		                &v24,
		                (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)Patch,
		                v14,
		                MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		              Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_freeRectangles;
		              v19.m128i_i32[0] = (__int32)v24.ptr;
		              if ( !Patch )
		                goto LABEL_21;
		              System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		                &v25,
		                (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)Patch,
		                v14,
		                MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		              v17 = (unsigned __int64)v25.ptr >> 32;
		              *bestY = v16;
		              Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_freeRectangles;
		              *(__int64 *)((char *)v19.m128i_i64 + 4) = __PAIR64__(width, v17);
		              v19.m128i_i32[3] = height;
		              if ( !Patch )
		                goto LABEL_21;
		              System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		                (ObjectTranslator_LuaCSFunctionPtr *)v26,
		                (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)Patch,
		                v14,
		                MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		              v13 = (RectInt)_mm_loadu_si128(&v19);
		              *bestX = v26[0].m_XMin;
		            }
		          }
		          v10 = width;
		        }
		      }
		      ++v14;
		    }
		    *retstr = v13;
		  }
		  return retstr;
		}
		
		private RectInt _FindPositionForNewNodeContactPoint(int width, int height, out int bestContactScore) {
			bestContactScore = default;
			return default;
		} // 0x0000000189B6FCA8-0x0000000189B6FEA8
		// RectInt _FindPositionForNewNodeContactPoint(Int32, Int32, Int32 ByRef)
		RectInt *HG::Rendering::Runtime::AtlasMaxRect::_FindPositionForNewNodeContactPoint(
		        RectInt *__return_ptr retstr,
		        AtlasMaxRect *this,
		        int32_t width,
		        int32_t height,
		        int32_t *bestContactScore,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 ptr_low; // rcx
		  RectInt v12; // xmm6
		  int32_t i; // ebx
		  List_1_UnityEngine_RectInt_ *m_freeRectangles; // rax
		  int32_t v15; // r13d
		  __m128i v17; // [rsp+48h] [rbp-59h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v18; // [rsp+58h] [rbp-49h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v19; // [rsp+68h] [rbp-39h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v20; // [rsp+78h] [rbp-29h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr x; // [rsp+88h] [rbp-19h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v22; // [rsp+98h] [rbp-9h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v23; // [rsp+A8h] [rbp+7h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2744, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2744, 0LL);
		    if ( !Patch )
		LABEL_17:
		      sub_1800D8260(ptr_low, Patch);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1003(
		                 (RectInt *)&v23,
		                 Patch,
		                 (Object *)this,
		                 width,
		                 height,
		                 bestContactScore,
		                 0LL);
		  }
		  else
		  {
		    v12 = 0LL;
		    v17 = 0LL;
		    *bestContactScore = -1;
		    for ( i = 0; ; ++i )
		    {
		      m_freeRectangles = this->fields.m_freeRectangles;
		      if ( !m_freeRectangles )
		        goto LABEL_17;
		      if ( i >= m_freeRectangles->fields._size )
		        break;
		      System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		        &v18,
		        (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_freeRectangles,
		        i,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		      if ( SLODWORD(v18.target) >= width )
		      {
		        Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_freeRectangles;
		        if ( !Patch )
		          goto LABEL_17;
		        System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		          &v19,
		          (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)Patch,
		          i,
		          MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		        if ( SHIDWORD(v19.target) >= height )
		        {
		          Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_freeRectangles;
		          if ( !Patch )
		            goto LABEL_17;
		          System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		            &x,
		            (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)Patch,
		            i,
		            MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		          Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_freeRectangles;
		          if ( !Patch )
		            goto LABEL_17;
		          System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		            &v20,
		            (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)Patch,
		            i,
		            MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		          v15 = HG::Rendering::Runtime::AtlasMaxRect::_ContactPointScoreNode(
		                  this,
		                  (int32_t)x.ptr,
		                  SHIDWORD(v20.ptr),
		                  width,
		                  height,
		                  0LL);
		          if ( v15 > *bestContactScore )
		          {
		            Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_freeRectangles;
		            if ( !Patch )
		              goto LABEL_17;
		            System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		              &v22,
		              (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)Patch,
		              i,
		              MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		            Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_freeRectangles;
		            ptr_low = LODWORD(v22.ptr);
		            v17.m128i_i32[0] = (__int32)v22.ptr;
		            if ( !Patch )
		              goto LABEL_17;
		            System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		              &v23,
		              (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)Patch,
		              i,
		              MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		            *(__int64 *)((char *)v17.m128i_i64 + 4) = __PAIR64__(width, HIDWORD(v23.ptr));
		            v17.m128i_i32[3] = height;
		            v12 = (RectInt)_mm_loadu_si128(&v17);
		            *bestContactScore = v15;
		          }
		        }
		      }
		    }
		    *retstr = v12;
		  }
		  return retstr;
		}
		
		private RectInt _FindPositionForNewNodeBestLongSideFit(int width, int height, out int bestShortSideFit, out int bestLongSideFit) {
			bestShortSideFit = default;
			bestLongSideFit = default;
			return default;
		} // 0x0000000189B6F608-0x0000000189B6F838
		// RectInt _FindPositionForNewNodeBestLongSideFit(Int32, Int32, Int32 ByRef, Int32 ByRef)
		RectInt *HG::Rendering::Runtime::AtlasMaxRect::_FindPositionForNewNodeBestLongSideFit(
		        RectInt *__return_ptr retstr,
		        AtlasMaxRect *this,
		        int32_t width,
		        int32_t height,
		        int32_t *bestShortSideFit,
		        int32_t *bestLongSideFit,
		        MethodInfo *method)
		{
		  int v9; // r14d
		  int v10; // esi
		  List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *Patch; // rdx
		  __int64 v12; // rcx
		  RectInt v13; // xmm6
		  int32_t v14; // ebx
		  List_1_UnityEngine_RectInt_ *m_freeRectangles; // rax
		  int32_t v16; // eax
		  int32_t v17; // esi
		  int32_t v18; // eax
		  int32_t v19; // r14d
		  __m128i v21; // [rsp+48h] [rbp-71h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v22; // [rsp+58h] [rbp-61h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v23; // [rsp+68h] [rbp-51h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v24; // [rsp+78h] [rbp-41h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v25; // [rsp+88h] [rbp-31h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v26; // [rsp+98h] [rbp-21h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v27; // [rsp+A8h] [rbp-11h] BYREF
		
		  v9 = height;
		  v10 = width;
		  if ( !IFix::WrappersManagerImpl::IsPatched(2748, 0LL) )
		  {
		    v13 = 0LL;
		    v21 = 0LL;
		    v14 = 0;
		    *bestShortSideFit = 0x7FFFFFFF;
		    *bestLongSideFit = 0x7FFFFFFF;
		    while ( 1 )
		    {
		      m_freeRectangles = this->fields.m_freeRectangles;
		      if ( !m_freeRectangles )
		        goto LABEL_24;
		      if ( v14 >= m_freeRectangles->fields._size )
		      {
		        *retstr = v13;
		        return retstr;
		      }
		      System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		        &v22,
		        (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_freeRectangles,
		        v14,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		      if ( SLODWORD(v22.target) >= v10 )
		      {
		        Patch = (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_freeRectangles;
		        if ( !Patch )
		          goto LABEL_24;
		        System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		          &v23,
		          Patch,
		          v14,
		          MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		        if ( SHIDWORD(v23.target) >= v9 )
		          break;
		      }
		LABEL_21:
		      ++v14;
		    }
		    Patch = (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_freeRectangles;
		    if ( !Patch )
		      goto LABEL_24;
		    System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		      &v24,
		      Patch,
		      v14,
		      MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		    v16 = sub_1833FD1B0((unsigned int)(LODWORD(v24.target) - v10));
		    Patch = (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_freeRectangles;
		    v17 = v16;
		    if ( !Patch )
		      goto LABEL_24;
		    System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		      &v25,
		      Patch,
		      v14,
		      MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		    v18 = sub_1833FD1B0((unsigned int)(HIDWORD(v25.target) - v9));
		    if ( v17 >= v18 )
		    {
		      v19 = v18;
		      if ( v17 > v18 )
		        goto LABEL_14;
		    }
		    else
		    {
		      v19 = v17;
		    }
		    v17 = v18;
		LABEL_14:
		    if ( v17 < *bestLongSideFit || v17 == *bestLongSideFit && v19 < *bestShortSideFit )
		    {
		      Patch = (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_freeRectangles;
		      if ( !Patch )
		        goto LABEL_24;
		      System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		        &v26,
		        Patch,
		        v14,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		      Patch = (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_freeRectangles;
		      v21.m128i_i32[0] = (__int32)v26.ptr;
		      if ( !Patch )
		        goto LABEL_24;
		      System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		        &v27,
		        Patch,
		        v14,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		      *(__int64 *)((char *)v21.m128i_i64 + 4) = __PAIR64__(width, HIDWORD(v27.ptr));
		      v21.m128i_i32[3] = height;
		      v13 = (RectInt)_mm_loadu_si128(&v21);
		      *bestShortSideFit = v19;
		      *bestLongSideFit = v17;
		    }
		    v10 = width;
		    v9 = height;
		    goto LABEL_21;
		  }
		  Patch = (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)IFix::WrappersManagerImpl::GetPatch(2748, 0LL);
		  if ( !Patch )
		LABEL_24:
		    sub_1800D8260(v12, Patch);
		  *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1001(
		               (RectInt *)&v27,
		               (ILFixDynamicMethodWrapper_2 *)Patch,
		               (Object *)this,
		               v10,
		               v9,
		               bestShortSideFit,
		               bestLongSideFit,
		               0LL);
		  return retstr;
		}
		
		private RectInt _FindPositionForNewNodeBestAreaFit(int width, int height, out int bestAreaFit, out int bestShortSideFit) {
			bestAreaFit = default;
			bestShortSideFit = default;
			return default;
		} // 0x0000000189B6F384-0x0000000189B6F608
		// RectInt _FindPositionForNewNodeBestAreaFit(Int32, Int32, Int32 ByRef, Int32 ByRef)
		RectInt *HG::Rendering::Runtime::AtlasMaxRect::_FindPositionForNewNodeBestAreaFit(
		        RectInt *__return_ptr retstr,
		        AtlasMaxRect *this,
		        int32_t width,
		        int32_t height,
		        int32_t *bestAreaFit,
		        int32_t *bestShortSideFit,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v12; // rcx
		  RectInt v13; // xmm6
		  int32_t v14; // ebx
		  List_1_UnityEngine_RectInt_ *m_freeRectangles; // rax
		  int v16; // esi
		  int32_t v17; // eax
		  int32_t v18; // eax
		  __m128i v20; // [rsp+48h] [rbp-81h] BYREF
		  RectInt v21; // [rsp+58h] [rbp-71h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v22; // [rsp+68h] [rbp-61h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v23; // [rsp+78h] [rbp-51h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v24; // [rsp+88h] [rbp-41h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v25; // [rsp+98h] [rbp-31h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v26; // [rsp+A8h] [rbp-21h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v27; // [rsp+B8h] [rbp-11h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v28; // [rsp+C8h] [rbp-1h] BYREF
		  int32_t v29; // [rsp+118h] [rbp+4Fh]
		  int32_t v30; // [rsp+118h] [rbp+4Fh]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2750, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2750, 0LL);
		    if ( !Patch )
		LABEL_23:
		      sub_1800D8260(v12, Patch);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1001(
		                 &v21,
		                 Patch,
		                 (Object *)this,
		                 width,
		                 height,
		                 bestAreaFit,
		                 bestShortSideFit,
		                 0LL);
		  }
		  else
		  {
		    v12 = 0x7FFFFFFFLL;
		    v13 = 0LL;
		    v20 = 0LL;
		    v14 = 0;
		    *bestAreaFit = 0x7FFFFFFF;
		    *bestShortSideFit = 0x7FFFFFFF;
		    while ( 1 )
		    {
		      m_freeRectangles = this->fields.m_freeRectangles;
		      if ( !m_freeRectangles )
		        goto LABEL_23;
		      if ( v14 >= m_freeRectangles->fields._size )
		        break;
		      System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		        &v23,
		        (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.m_freeRectangles,
		        v14,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		      Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_freeRectangles;
		      if ( !Patch )
		        goto LABEL_23;
		      System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		        &v22,
		        (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)Patch,
		        v14,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		      Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_freeRectangles;
		      v16 = LODWORD(v23.target) * HIDWORD(v22.target) - height * width;
		      if ( !Patch )
		        goto LABEL_23;
		      System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		        &v24,
		        (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)Patch,
		        v14,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		      if ( SLODWORD(v24.target) >= width )
		      {
		        Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_freeRectangles;
		        if ( !Patch )
		          goto LABEL_23;
		        System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		          &v25,
		          (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)Patch,
		          v14,
		          MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		        if ( SHIDWORD(v25.target) >= height )
		        {
		          Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_freeRectangles;
		          if ( !Patch )
		            goto LABEL_23;
		          System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		            &v26,
		            (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)Patch,
		            v14,
		            MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		          v17 = sub_1833FD1B0((unsigned int)(LODWORD(v26.target) - width));
		          Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_freeRectangles;
		          v29 = v17;
		          if ( !Patch )
		            goto LABEL_23;
		          System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		            &v27,
		            (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)Patch,
		            v14,
		            MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		          v18 = sub_1833FD1B0((unsigned int)(HIDWORD(v27.target) - height));
		          if ( v29 < v18 )
		            v18 = v29;
		          v30 = v18;
		          if ( v16 < *bestAreaFit || v16 == *bestAreaFit && (v12 = (__int64)bestShortSideFit, v18 < *bestShortSideFit) )
		          {
		            Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_freeRectangles;
		            if ( !Patch )
		              goto LABEL_23;
		            System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		              &v28,
		              (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)Patch,
		              v14,
		              MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		            Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_freeRectangles;
		            v20.m128i_i32[0] = (__int32)v28.ptr;
		            if ( !Patch )
		              goto LABEL_23;
		            System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		              (ObjectTranslator_LuaCSFunctionPtr *)&v21,
		              (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)Patch,
		              v14,
		              MethodInfo::System::Collections::Generic::List<UnityEngine::RectInt>::get_Item);
		            v12 = (__int64)bestShortSideFit;
		            *(__int64 *)((char *)v20.m128i_i64 + 4) = __PAIR64__(width, v21.m_YMin);
		            v20.m128i_i32[3] = height;
		            v13 = (RectInt)_mm_loadu_si128(&v20);
		            *bestShortSideFit = v30;
		            *bestAreaFit = v16;
		          }
		        }
		      }
		      ++v14;
		    }
		    *retstr = v13;
		  }
		  return retstr;
		}
		
	}
}
