using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class AtlasGuillotine // TypeDefIndex: 38076
	{
		// Fields
		private const int INDEX_NONE = -1; // Metadata: 0x0230387C
		private readonly int m_sizeX; // 0x10
		private readonly int m_sizeY; // 0x14
		private readonly List<TextureLayoutNode> m_nodes; // 0x18
	
		// Nested types
		private struct TextureLayoutNode // TypeDefIndex: 38075
		{
			// Fields
			public int childA; // 0x00
			public int childB; // 0x04
			public readonly ushort xMin; // 0x08
			public readonly ushort yMin; // 0x0A
			public readonly ushort xSize; // 0x0C
			public readonly ushort ySize; // 0x0E
			public bool used; // 0x10
	
			// Constructors
			public TextureLayoutNode(ushort inXMin, ushort inYMin, ushort inXSize, ushort inYSize) {
				childA = default;
				childB = default;
				xMin = default;
				yMin = default;
				xSize = default;
				ySize = default;
				used = default;
			} // 0x0000000184DA1750-0x0000000184DA1780
			// AtlasGuillotine+TextureLayoutNode(UInt16, UInt16, UInt16, UInt16)
			void HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode::TextureLayoutNode(
			        AtlasGuillotine_TextureLayoutNode *this,
			        uint16_t inXMin,
			        uint16_t inYMin,
			        uint16_t inXSize,
			        uint16_t inYSize,
			        MethodInfo *method)
			{
			  this->ySize = inYSize;
			  *(_QWORD *)&this->childA = -1LL;
			  this->xMin = inXMin;
			  this->yMin = inYMin;
			  this->xSize = inXSize;
			  this->used = 0;
			}
			
	
			// Methods
			public override bool Equals(object obj) => default; // 0x0000000189B74E70-0x0000000189B74F3C
			// Boolean Equals(Object)
			bool HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode::Equals(
			        AtlasGuillotine_TextureLayoutNode *this,
			        Object *obj,
			        MethodInfo *method)
			{
			  __m128i *v5; // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v8; // rdx
			  __int64 v9; // rcx
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(2734, 0LL) )
			    return obj
			        && (struct AtlasGuillotine_TextureLayoutNode__Class *)obj->klass == TypeInfo::HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode
			        && (v5 = (__m128i *)sub_1800422D0(obj),
			            *(_OWORD *)&this->childA == __PAIR128__(
			                                          __PAIR64__(
			                                            HIDWORD(v5->m128i_i64[1]),
			                                            __PAIR32__(WORD1(v5->m128i_i64[1]), _mm_extract_epi16(*v5, 4))),
			                                          __PAIR64__(HIDWORD(v5->m128i_i64[0]), _mm_cvtsi128_si32(*v5))))
			        && this->used == (unsigned __int8)v5[1].m128i_i32[0];
			  Patch = IFix::WrappersManagerImpl::GetPatch(2734, 0LL);
			  if ( !Patch )
			    sub_1800D8260(v9, v8);
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_998(Patch, this, obj, 0LL);
			}
			
			public override int GetHashCode() => default; // 0x0000000189B74F3C-0x0000000189B75008
			// Int32 GetHashCode()
			int32_t HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode::GetHashCode(
			        AtlasGuillotine_TextureLayoutNode *this,
			        MethodInfo *method)
			{
			  int32_t childA; // r12d
			  int32_t childB; // r15d
			  uint16_t xMin; // r14
			  uint16_t yMin; // bp
			  uint16_t value5; // si
			  uint16_t value6; // di
			  bool value7; // bl
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v12; // rdx
			  __int64 v13; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(2735, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(2735, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v13, v12);
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_999(Patch, this, 0LL);
			  }
			  else
			  {
			    childA = this->childA;
			    childB = this->childB;
			    xMin = this->xMin;
			    yMin = this->yMin;
			    value5 = this->xSize;
			    value6 = this->ySize;
			    value7 = this->used;
			    sub_1800036A0(TypeInfo::System::HashCode);
			    return System::HashCode::Combine<int,int,unsigned short,unsigned short,unsigned short,unsigned short,bool>(
			             childA,
			             childB,
			             xMin,
			             yMin,
			             value5,
			             value6,
			             value7,
			             MethodInfo::System::HashCode::Combine<int,int,unsigned short,unsigned short,unsigned short,unsigned short,bool>);
			  }
			}
			
			public static bool operator ==(TextureLayoutNode a, TextureLayoutNode b) => default; // 0x0000000189B75078-0x0000000189B75174
			// Boolean op_Equality(AtlasGuillotine+TextureLayoutNode, AtlasGuillotine+TextureLayoutNode)
			bool HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode::op_Equality(
			        AtlasGuillotine_TextureLayoutNode *a,
			        AtlasGuillotine_TextureLayoutNode *b,
			        MethodInfo *method)
			{
			  __int64 v6; // rdx
			  ILFixDynamicMethodWrapper_2 *Patch; // rcx
			  __int128 v8; // xmm0
			  int v9; // eax
			  __int128 v10; // xmm0
			  AtlasGuillotine_TextureLayoutNode v11; // [rsp+20h] [rbp-40h] BYREF
			  AtlasGuillotine_TextureLayoutNode v12; // [rsp+40h] [rbp-20h] BYREF
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(2736, 0LL) )
			    return (unsigned __int16)_mm_extract_epi16(*(__m128i *)&a->childA, 4) == (unsigned __int16)_mm_extract_epi16(
			                                                                                                 *(__m128i *)&b->childA,
			                                                                                                 4)
			        && WORD1(*(_QWORD *)&a->xMin) == WORD1(*(_QWORD *)&b->xMin)
			        && HIWORD(*(_QWORD *)&a->xMin) == HIWORD(*(_QWORD *)&b->xMin)
			        && __PAIR64__(HIDWORD(*(_QWORD *)&a->childA), _mm_cvtsi128_si32(*(__m128i *)&a->childA)) == *(_QWORD *)&b->childA
			        && (unsigned __int8)*(_DWORD *)&a->used == b->used;
			  Patch = IFix::WrappersManagerImpl::GetPatch(2736, 0LL);
			  if ( !Patch )
			    sub_1800D8260(0LL, v6);
			  v8 = *(_OWORD *)&b->childA;
			  *(_DWORD *)&v11.used = *(_DWORD *)&b->used;
			  v9 = *(_DWORD *)&a->used;
			  *(_OWORD *)&v11.childA = v8;
			  v10 = *(_OWORD *)&a->childA;
			  *(_DWORD *)&v12.used = v9;
			  *(_OWORD *)&v12.childA = v10;
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1000(Patch, &v12, &v11, 0LL);
			}
			
			public static bool operator !=(TextureLayoutNode a, TextureLayoutNode b) => default; // 0x0000000189B75174-0x0000000189B75270
			// Boolean op_Inequality(AtlasGuillotine+TextureLayoutNode, AtlasGuillotine+TextureLayoutNode)
			bool HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode::op_Inequality(
			        AtlasGuillotine_TextureLayoutNode *a,
			        AtlasGuillotine_TextureLayoutNode *b,
			        MethodInfo *method)
			{
			  __int64 v6; // rdx
			  ILFixDynamicMethodWrapper_2 *Patch; // rcx
			  __int128 v8; // xmm0
			  int v9; // eax
			  __int128 v10; // xmm0
			  AtlasGuillotine_TextureLayoutNode v11; // [rsp+20h] [rbp-40h] BYREF
			  AtlasGuillotine_TextureLayoutNode v12; // [rsp+40h] [rbp-20h] BYREF
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(2737, 0LL) )
			    return (unsigned __int16)_mm_extract_epi16(*(__m128i *)&a->childA, 4) != (unsigned __int16)_mm_extract_epi16(
			                                                                                                 *(__m128i *)&b->childA,
			                                                                                                 4)
			        || WORD1(*(_QWORD *)&a->xMin) != WORD1(*(_QWORD *)&b->xMin)
			        || HIWORD(*(_QWORD *)&a->xMin) != HIWORD(*(_QWORD *)&b->xMin)
			        || __PAIR64__(HIDWORD(*(_QWORD *)&a->childA), _mm_cvtsi128_si32(*(__m128i *)&a->childA)) != *(_QWORD *)&b->childA
			        || (unsigned __int8)*(_DWORD *)&a->used != b->used;
			  Patch = IFix::WrappersManagerImpl::GetPatch(2737, 0LL);
			  if ( !Patch )
			    sub_1800D8260(0LL, v6);
			  v8 = *(_OWORD *)&b->childA;
			  *(_DWORD *)&v11.used = *(_DWORD *)&b->used;
			  v9 = *(_DWORD *)&a->used;
			  *(_OWORD *)&v11.childA = v8;
			  v10 = *(_OWORD *)&a->childA;
			  *(_DWORD *)&v12.used = v9;
			  *(_OWORD *)&v12.childA = v10;
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1000(Patch, &v12, &v11, 0LL);
			}
			
			public bool __iFixBaseProxy_Equals(object P0) => default; // 0x0000000189B75008-0x0000000189B75044
			// Boolean <>iFixBaseProxy_Equals(Object)
			bool HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode::__iFixBaseProxy_Equals(
			        AtlasGuillotine_TextureLayoutNode *this,
			        Object *P0,
			        MethodInfo *method)
			{
			  int v3; // eax
			  Object *v5; // rax
			  __int128 v7; // [rsp+20h] [rbp-28h] BYREF
			  int v8; // [rsp+30h] [rbp-18h]
			
			  v3 = *(_DWORD *)&this->used;
			  v7 = *(_OWORD *)&this->childA;
			  v8 = v3;
			  v5 = (Object *)il2cpp_value_box_0(TypeInfo::HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode, &v7);
			  return System::ValueType::DefaultEquals(v5, P0, 0LL);
			}
			
			public int __iFixBaseProxy_GetHashCode() => default; // 0x0000000189B75044-0x0000000189B75078
			// Int32 <>iFixBaseProxy_GetHashCode()
			int32_t HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode::__iFixBaseProxy_GetHashCode(
			        AtlasGuillotine_TextureLayoutNode *this,
			        MethodInfo *method)
			{
			  int v2; // eax
			  ValueType *v3; // rax
			  __int128 v5; // [rsp+20h] [rbp-28h] BYREF
			  int v6; // [rsp+30h] [rbp-18h]
			
			  v2 = *(_DWORD *)&this->used;
			  v5 = *(_OWORD *)&this->childA;
			  v6 = v2;
			  v3 = (ValueType *)il2cpp_value_box_0(TypeInfo::HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode, &v5);
			  return System::ValueType::GetHashCode(v3, 0LL);
			}
			
		}
	
		// Constructors
		public AtlasGuillotine() {} // Dummy constructor
		public AtlasGuillotine(int maxSizeX, int maxSizeY) {} // 0x0000000189B68270-0x0000000189B68338
		// AtlasGuillotine(Int32, Int32)
		void HG::Rendering::Runtime::AtlasGuillotine::AtlasGuillotine(
		        AtlasGuillotine *this,
		        int32_t maxSizeX,
		        int32_t maxSizeY,
		        MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *v7; // rax
		  __int64 v8; // rdx
		  List_1_HG_Rendering_Runtime_AtlasGuillotine_TextureLayoutNode_ *m_nodes; // rcx
		  List_1_HG_Rendering_Runtime_AtlasGuillotine_TextureLayoutNode_ *v10; // rdi
		  Type *v11; // rdx
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  MethodInfo *v14; // [rsp+20h] [rbp-40h]
		  __int128 v15; // [rsp+20h] [rbp-40h]
		  int v16; // [rsp+30h] [rbp-30h]
		  __int128 v17; // [rsp+40h] [rbp-20h] BYREF
		  int v18; // [rsp+50h] [rbp-10h]
		
		  *(_WORD *)((char *)&v16 + 1) = 0;
		  HIBYTE(v16) = 0;
		  v7 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode>);
		  v10 = (List_1_HG_Rendering_Runtime_AtlasGuillotine_TextureLayoutNode_ *)v7;
		  if ( !v7 )
		    goto LABEL_4;
		  System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::List(
		    v7,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode>::List);
		  this->fields.m_nodes = v10;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_nodes, v11, v12, v13, v14);
		  m_nodes = this->fields.m_nodes;
		  this->fields.m_sizeX = maxSizeX;
		  this->fields.m_sizeY = maxSizeY;
		  *(_QWORD *)&v15 = -1LL;
		  DWORD2(v15) = 0;
		  WORD6(v15) = maxSizeX;
		  HIWORD(v15) = maxSizeY;
		  LOBYTE(v16) = 0;
		  if ( !m_nodes )
		LABEL_4:
		    sub_1800D8260(m_nodes, v8);
		  v17 = v15;
		  v18 = v16;
		  sub_180463AD0(
		    m_nodes,
		    &v17,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode>::Add);
		}
		
	
		// Methods
		public RectInt InsertRect(int width, int height) => default; // 0x0000000189B6743C-0x0000000189B674E8
		// RectInt InsertRect(Int32, Int32)
		RectInt *HG::Rendering::Runtime::AtlasGuillotine::InsertRect(
		        RectInt *__return_ptr retstr,
		        AtlasGuillotine *this,
		        int32_t width,
		        int32_t height,
		        MethodInfo *method)
		{
		  RectInt v9; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  RectInt *result; // rax
		  RectInt rect; // [rsp+30h] [rbp-18h] BYREF
		
		  rect = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2725, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2725, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v12, v11);
		    v9 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_659(&rect, Patch, (Object *)this, width, height, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::AtlasGuillotine::_AddElement(this, width, height, &rect, 0LL);
		    v9 = rect;
		  }
		  result = retstr;
		  *retstr = v9;
		  return result;
		}
		
		public void RemoveRect([IsReadOnly] in RectInt rect) {} // 0x0000000189B674E8-0x0000000189B67564
		// Void RemoveRect(RectInt ByRef)
		void HG::Rendering::Runtime::AtlasGuillotine::RemoveRect(AtlasGuillotine *this, RectInt *rect, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2728, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2728, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_656(Patch, (Object *)this, rect, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::AtlasGuillotine::_RemoveElement(
		      this,
		      *(_QWORD *)&rect->m_XMin,
		      HIDWORD(*(_QWORD *)&rect->m_XMin),
		      *(_QWORD *)&rect->m_Width,
		      HIDWORD(*(_QWORD *)&rect->m_Width),
		      0LL);
		  }
		}
		
		public void Reset() {} // 0x0000000189B67564-0x0000000189B67620
		// Void Reset()
		void HG::Rendering::Runtime::AtlasGuillotine::Reset(AtlasGuillotine *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  List_1_HG_Rendering_Runtime_AtlasGuillotine_TextureLayoutNode_ *m_nodes; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v6; // [rsp+20h] [rbp-40h]
		  int v7; // [rsp+30h] [rbp-30h]
		  __int128 v8; // [rsp+40h] [rbp-20h] BYREF
		  int v9; // [rsp+50h] [rbp-10h]
		
		  *(_WORD *)((char *)&v7 + 1) = 0;
		  HIBYTE(v7) = 0;
		  if ( !IFix::WrappersManagerImpl::IsPatched(2733, 0LL) )
		  {
		    m_nodes = this->fields.m_nodes;
		    if ( m_nodes )
		    {
		      ++m_nodes->fields._version;
		      m_nodes->fields._size = 0;
		      m_nodes = this->fields.m_nodes;
		      *(_QWORD *)&v6 = -1LL;
		      WORD6(v6) = this->fields.m_sizeX;
		      HIWORD(v6) = this->fields.m_sizeY;
		      DWORD2(v6) = 0;
		      LOBYTE(v7) = 0;
		      if ( m_nodes )
		      {
		        v8 = v6;
		        v9 = v7;
		        sub_180463AD0(
		          m_nodes,
		          &v8,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode>::Add);
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(m_nodes, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2733, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private void _AddElement(int elementSizeX, int elementSizeY, out RectInt rect) {
			rect = default;
		} // 0x0000000189B67620-0x0000000189B67768
		// Void _AddElement(Int32, Int32, RectInt ByRef)
		void HG::Rendering::Runtime::AtlasGuillotine::_AddElement(
		        AtlasGuillotine *this,
		        int32_t elementSizeX,
		        int32_t elementSizeY,
		        RectInt *rect,
		        MethodInfo *method)
		{
		  int32_t v9; // eax
		  List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *v10; // rcx
		  int32_t v11; // r15d
		  List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *m_nodes; // rdx
		  __m128i v13; // xmm6
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  SpatialPortalManager_FQueuedPortalObstructedData v15; // [rsp+30h] [rbp-50h] BYREF
		  SpatialPortalManager_FQueuedPortalObstructedData v16; // [rsp+50h] [rbp-30h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2726, 0LL) )
		  {
		    *rect = 0LL;
		    v9 = HG::Rendering::Runtime::AtlasGuillotine::_AddSurfaceInner(this, 0, elementSizeX, elementSizeY, 0LL);
		    v11 = v9;
		    if ( v9 == -1 )
		      return;
		    m_nodes = (List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *)this->fields.m_nodes;
		    if ( m_nodes )
		    {
		      System::Collections::Generic::List<Beyond::Gameplay::Audio::SpatialPortalManager::FQueuedPortalObstructedData>::get_Item(
		        &v15,
		        m_nodes,
		        v9,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode>::get_Item);
		      v10 = (List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *)this->fields.m_nodes;
		      v16.fadeTime = v15.fadeTime;
		      v13 = *(__m128i *)&v15.position.x;
		      if ( v10 )
		      {
		        *(_WORD *)((char *)&v15.fadeTime + 1) = *(_WORD *)((char *)&v16.fadeTime + 1);
		        HIBYTE(v15.fadeTime) = HIBYTE(v16.fadeTime);
		        LOBYTE(v15.fadeTime) = 1;
		        v16 = v15;
		        System::Collections::Generic::List<Beyond::Gameplay::Audio::SpatialPortalManager::FQueuedPortalObstructedData>::set_Item(
		          v10,
		          v11,
		          &v16,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode>::set_Item);
		        rect->m_Width = elementSizeX;
		        rect->m_YMin = _mm_srli_si128(v13, 8).m128i_u16[1];
		        rect->m_XMin = _mm_extract_epi16(v13, 4);
		        rect->m_Height = elementSizeY;
		        return;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v10, m_nodes);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2726, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_996(Patch, (Object *)this, elementSizeX, elementSizeY, rect, 0LL);
		}
		
		private void _RemoveElement(int elementBaseX, int elementBaseY, int elementSizeX, int elementSizeY) {} // 0x0000000189B6803C-0x0000000189B68270
		// Void _RemoveElement(Int32, Int32, Int32, Int32)
		void HG::Rendering::Runtime::AtlasGuillotine::_RemoveElement(
		        AtlasGuillotine *this,
		        int32_t elementBaseX,
		        int32_t elementBaseY,
		        int32_t elementSizeX,
		        int32_t elementSizeY,
		        MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *v10; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  int32_t i; // edi
		  List_1_HG_Rendering_Runtime_AtlasGuillotine_TextureLayoutNode_ *m_nodes; // rax
		  int32_t ParentNode; // eax
		  int32_t v15; // edi
		  int32_t v16; // esi
		  SpatialPortalManager_FQueuedPortalObstructedData v17; // [rsp+40h] [rbp-40h] BYREF
		  SpatialPortalManager_FQueuedPortalObstructedData nodeIndex; // [rsp+60h] [rbp-20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2729, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2729, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_997(
		        Patch,
		        (Object *)this,
		        elementBaseX,
		        elementBaseY,
		        elementSizeX,
		        elementSizeY,
		        0LL);
		      return;
		    }
		    goto LABEL_24;
		  }
		  for ( i = 0; ; ++i )
		  {
		    m_nodes = this->fields.m_nodes;
		    if ( !m_nodes )
		      goto LABEL_24;
		    if ( i >= m_nodes->fields._size )
		      return;
		    System::Collections::Generic::List<Beyond::Gameplay::Audio::SpatialPortalManager::FQueuedPortalObstructedData>::get_Item(
		      &nodeIndex,
		      (List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *)this->fields.m_nodes,
		      i,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode>::get_Item);
		    Patch = *(ILFixDynamicMethodWrapper_2 **)&nodeIndex.position.z;
		    if ( LOWORD(nodeIndex.position.z) == elementBaseX
		      && HIWORD(nodeIndex.position.z) == elementBaseY
		      && LOWORD(nodeIndex.targetObstructedPercentage) == elementSizeX )
		    {
		      Patch = (ILFixDynamicMethodWrapper_2 *)HIWORD(nodeIndex.targetObstructedPercentage);
		      if ( HIWORD(nodeIndex.targetObstructedPercentage) == elementSizeY )
		        break;
		    }
		  }
		  if ( i != -1 )
		  {
		    v10 = (List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *)this->fields.m_nodes;
		    if ( v10 )
		    {
		      System::Collections::Generic::List<Beyond::Gameplay::Audio::SpatialPortalManager::FQueuedPortalObstructedData>::get_Item(
		        &v17,
		        v10,
		        i,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode>::get_Item);
		      Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_nodes;
		      nodeIndex.fadeTime = v17.fadeTime;
		      if ( Patch )
		      {
		        *(_WORD *)((char *)&v17.fadeTime + 1) = *(_WORD *)((char *)&nodeIndex.fadeTime + 1);
		        HIBYTE(v17.fadeTime) = HIBYTE(nodeIndex.fadeTime);
		        LOBYTE(v17.fadeTime) = 0;
		        nodeIndex = v17;
		        System::Collections::Generic::List<Beyond::Gameplay::Audio::SpatialPortalManager::FQueuedPortalObstructedData>::set_Item(
		          (List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *)Patch,
		          i,
		          &nodeIndex,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode>::set_Item);
		        ParentNode = HG::Rendering::Runtime::AtlasGuillotine::_FindParentNode(this, i, 0LL);
		        v15 = ParentNode;
		        if ( ParentNode == -1 || !HG::Rendering::Runtime::AtlasGuillotine::_IsNodeUsed(this, ParentNode, 0LL) )
		        {
		          v16 = v15;
		          if ( v15 != -1 )
		          {
		            do
		            {
		              v10 = (List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *)this->fields.m_nodes;
		              if ( !v10 )
		                goto LABEL_24;
		              System::Collections::Generic::List<Beyond::Gameplay::Audio::SpatialPortalManager::FQueuedPortalObstructedData>::get_Item(
		                &nodeIndex,
		                v10,
		                v15,
		                MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode>::get_Item);
		              if ( HG::Rendering::Runtime::AtlasGuillotine::_IsNodeUsed(this, SLODWORD(nodeIndex.position.x), 0LL) )
		                break;
		              v10 = (List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *)this->fields.m_nodes;
		              if ( !v10 )
		                goto LABEL_24;
		              System::Collections::Generic::List<Beyond::Gameplay::Audio::SpatialPortalManager::FQueuedPortalObstructedData>::get_Item(
		                &nodeIndex,
		                v10,
		                v15,
		                MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode>::get_Item);
		              if ( HG::Rendering::Runtime::AtlasGuillotine::_IsNodeUsed(this, SLODWORD(nodeIndex.position.y), 0LL) )
		                break;
		              v16 = v15;
		              v15 = HG::Rendering::Runtime::AtlasGuillotine::_FindParentNode(this, v15, 0LL);
		            }
		            while ( v15 != -1 );
		            if ( v16 != -1 )
		              HG::Rendering::Runtime::AtlasGuillotine::_RemoveChildren(this, v16, 0LL);
		          }
		        }
		        return;
		      }
		    }
		LABEL_24:
		    sub_1800D8260(Patch, v10);
		  }
		}
		
		private bool _IsNodeUsed(int nodeIndex) => default; // 0x0000000189B67C44-0x0000000189B67CFC
		// Boolean _IsNodeUsed(Int32)
		bool HG::Rendering::Runtime::AtlasGuillotine::_IsNodeUsed(AtlasGuillotine *this, int32_t nodeIndex, MethodInfo *method)
		{
		  __int64 v5; // rcx
		  char v6; // bl
		  List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *m_nodes; // rdx
		  float y; // rdi^4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  SpatialPortalManager_FQueuedPortalObstructedData nodeIndexa[2]; // [rsp+20h] [rbp-28h] BYREF
		
		  v6 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(2731, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2731, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_17(
		               (ILFixDynamicMethodWrapper_13 *)Patch,
		               (Object *)this,
		               (NaviDirection__Enum)nodeIndex,
		               0LL);
		LABEL_9:
		    sub_1800D8260(v5, m_nodes);
		  }
		  m_nodes = (List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *)this->fields.m_nodes;
		  if ( !m_nodes )
		    goto LABEL_9;
		  System::Collections::Generic::List<Beyond::Gameplay::Audio::SpatialPortalManager::FQueuedPortalObstructedData>::get_Item(
		    nodeIndexa,
		    m_nodes,
		    nodeIndex,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode>::get_Item);
		  y = nodeIndexa[0].position.y;
		  if ( LODWORD(nodeIndexa[0].position.x) != -1
		    && (HG::Rendering::Runtime::AtlasGuillotine::_IsNodeUsed(this, SLODWORD(nodeIndexa[0].position.x), 0LL)
		     || HG::Rendering::Runtime::AtlasGuillotine::_IsNodeUsed(this, SLODWORD(y), 0LL)) )
		  {
		    v6 = 1;
		  }
		  return ((unsigned __int8)v6 | LOBYTE(nodeIndexa[0].fadeTime)) != 0;
		}
		
		private int _AddSurfaceInner(int nodeIndex, int elementSizeX, int elementSizeY) => default; // 0x0000000189B67768-0x0000000189B67B80
		// Int32 _AddSurfaceInner(Int32, Int32, Int32)
		int32_t HG::Rendering::Runtime::AtlasGuillotine::_AddSurfaceInner(
		        AtlasGuillotine *this,
		        int32_t nodeIndex,
		        int32_t elementSizeX,
		        int32_t elementSizeY,
		        MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *v9; // rcx
		  List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *m_nodes; // rdx
		  float y; // r14^4
		  unsigned __int64 v12; // xmm0_8
		  int32_t result; // eax
		  List_1_HG_Rendering_Runtime_AtlasGuillotine_TextureLayoutNode_ *v14; // r8
		  __int64 v15; // r14
		  List_1_HG_Rendering_Runtime_AtlasGuillotine_TextureLayoutNode_ *v16; // rcx
		  __int16 z_low; // r15
		  int32_t size; // r13d
		  List_1_HG_Rendering_Runtime_AtlasGuillotine_TextureLayoutNode_ *v19; // rax
		  SpatialPortalManager_FQueuedPortalObstructedData *v20; // rdx
		  __int64 v21; // r14
		  List_1_HG_Rendering_Runtime_AtlasGuillotine_TextureLayoutNode_ *v22; // rcx
		  List_1_HG_Rendering_Runtime_AtlasGuillotine_TextureLayoutNode_ *v23; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  SpatialPortalManager_FQueuedPortalObstructedData v25; // [rsp+38h] [rbp-91h] BYREF
		  int32_t v26; // [rsp+58h] [rbp-71h]
		  SpatialPortalManager_FQueuedPortalObstructedData v27; // [rsp+68h] [rbp-61h] BYREF
		  SpatialPortalManager_FQueuedPortalObstructedData v28; // [rsp+88h] [rbp-41h] BYREF
		  SpatialPortalManager_FQueuedPortalObstructedData v29; // [rsp+A8h] [rbp-21h]
		  SpatialPortalManager_FQueuedPortalObstructedData v30; // [rsp+C0h] [rbp-9h]
		  SpatialPortalManager_FQueuedPortalObstructedData nodeIndexa; // [rsp+D8h] [rbp+Fh] BYREF
		
		  *(_WORD *)((char *)&v28.fadeTime + 1) = 0;
		  HIBYTE(v28.fadeTime) = 0;
		  *(_WORD *)((char *)&v25.fadeTime + 1) = 0;
		  HIBYTE(v25.fadeTime) = 0;
		  *(_WORD *)((char *)&v29.fadeTime + 1) = 0;
		  HIBYTE(v29.fadeTime) = 0;
		  *(_WORD *)((char *)&v27.fadeTime + 1) = 0;
		  HIBYTE(v27.fadeTime) = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(2727, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2727, 0LL);
		    if ( !Patch )
		      goto LABEL_28;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_258(
		             (ILFixDynamicMethodWrapper_6 *)Patch,
		             (Object *)this,
		             nodeIndex,
		             elementSizeX,
		             elementSizeY,
		             0LL);
		  }
		  else
		  {
		    m_nodes = (List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *)this->fields.m_nodes;
		    if ( !m_nodes )
		      goto LABEL_28;
		    System::Collections::Generic::List<Beyond::Gameplay::Audio::SpatialPortalManager::FQueuedPortalObstructedData>::get_Item(
		      &nodeIndexa,
		      m_nodes,
		      nodeIndex,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode>::get_Item);
		    v30 = nodeIndexa;
		    y = nodeIndexa.position.y;
		    if ( LODWORD(nodeIndexa.position.x) == -1 )
		    {
		      if ( !LOBYTE(nodeIndexa.fadeTime) )
		      {
		        v12 = _mm_srli_si128(*(__m128i *)&nodeIndexa.position.x, 8).m128i_u64[0];
		        if ( WORD2(v12) >= elementSizeX
		          && (int)HIWORD(v12) >= elementSizeY
		          && elementSizeX + (unsigned __int16)v12 <= this->fields.m_sizeX
		          && elementSizeY + WORD1(v12) <= this->fields.m_sizeY )
		        {
		          if ( WORD2(v12) == elementSizeX && HIWORD(v12) == elementSizeY )
		            return nodeIndex;
		          v14 = this->fields.m_nodes;
		          m_nodes = (List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *)((unsigned int)HIWORD(v12) - elementSizeY);
		          v9 = (List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *)((unsigned int)WORD2(v12)
		                                                                                                - elementSizeX);
		          if ( (int)v9 > (int)m_nodes )
		          {
		            if ( !v14 )
		              goto LABEL_28;
		            v21 = *(_QWORD *)&v30.position.z;
		            v22 = this->fields.m_nodes;
		            z_low = LOWORD(v30.position.z);
		            size = v14->fields._size;
		            *(_QWORD *)&v28.position.x = -1LL;
		            v28.position.z = v30.position.z;
		            LOWORD(v28.targetObstructedPercentage) = elementSizeX;
		            HIWORD(v28.targetObstructedPercentage) = HIWORD(v30.targetObstructedPercentage);
		            LOBYTE(v28.fadeTime) = 0;
		            v27 = v28;
		            sub_180463AD0(
		              v22,
		              &v27,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode>::Add);
		            v23 = this->fields.m_nodes;
		            if ( !v23 )
		              goto LABEL_28;
		            v26 = v23->fields._size;
		            LOWORD(v25.position.z) = z_low + elementSizeX;
		            HIWORD(v25.position.z) = WORD1(v21);
		            *(_QWORD *)&v25.position.x = -1LL;
		            v9 = (List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *)this->fields.m_nodes;
		            LOWORD(v25.targetObstructedPercentage) = WORD2(v21) - elementSizeX;
		            HIWORD(v25.targetObstructedPercentage) = HIWORD(v21);
		            LOBYTE(v25.fadeTime) = 0;
		            if ( !v9 )
		              goto LABEL_28;
		            v20 = &v28;
		            v28 = v25;
		          }
		          else
		          {
		            if ( !v14 )
		              goto LABEL_28;
		            v15 = *(_QWORD *)&v30.position.z;
		            v16 = this->fields.m_nodes;
		            z_low = LOWORD(v30.position.z);
		            size = v14->fields._size;
		            *(_QWORD *)&v29.position.x = -1LL;
		            v29.position.z = v30.position.z;
		            LOWORD(v29.targetObstructedPercentage) = LOWORD(v30.targetObstructedPercentage);
		            HIWORD(v29.targetObstructedPercentage) = elementSizeY;
		            LOBYTE(v29.fadeTime) = 0;
		            v25 = v29;
		            sub_180463AD0(
		              v16,
		              &v25,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode>::Add);
		            v19 = this->fields.m_nodes;
		            if ( !v19 )
		              goto LABEL_28;
		            v26 = v19->fields._size;
		            *(_QWORD *)&v27.position.x = -1LL;
		            HIWORD(v27.position.z) = elementSizeY + WORD1(v15);
		            v9 = (List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *)this->fields.m_nodes;
		            LOWORD(v27.position.z) = z_low;
		            LOWORD(v27.targetObstructedPercentage) = WORD2(v15);
		            HIWORD(v27.targetObstructedPercentage) = HIWORD(v15) - elementSizeY;
		            LOBYTE(v27.fadeTime) = 0;
		            if ( !v9 )
		              goto LABEL_28;
		            v20 = &v25;
		            v25 = v27;
		          }
		          sub_180463AD0(
		            v9,
		            v20,
		            MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode>::Add);
		          v9 = (List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *)this->fields.m_nodes;
		          if ( v9 )
		          {
		            *(float *)((char *)&v25.position.z + 2) = *(float *)((char *)&v30.position.z + 2);
		            HIWORD(v25.targetObstructedPercentage) = HIWORD(v30.targetObstructedPercentage);
		            LOBYTE(v25.fadeTime) = LOBYTE(nodeIndexa.fadeTime);
		            *(_WORD *)((char *)&v25.fadeTime + 1) = *(_WORD *)((char *)&v30.fadeTime + 1);
		            HIBYTE(v25.fadeTime) = HIBYTE(v30.fadeTime);
		            *(_QWORD *)&v25.position.x = __PAIR64__(v26, size);
		            LOWORD(v25.position.z) = z_low;
		            nodeIndexa = v25;
		            System::Collections::Generic::List<Beyond::Gameplay::Audio::SpatialPortalManager::FQueuedPortalObstructedData>::set_Item(
		              v9,
		              nodeIndex,
		              &nodeIndexa,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode>::set_Item);
		            return HG::Rendering::Runtime::AtlasGuillotine::_AddSurfaceInner(
		                     this,
		                     size,
		                     elementSizeX,
		                     elementSizeY,
		                     0LL);
		          }
		LABEL_28:
		          sub_1800D8260(v9, m_nodes);
		        }
		      }
		      return -1;
		    }
		    else
		    {
		      result = HG::Rendering::Runtime::AtlasGuillotine::_AddSurfaceInner(
		                 this,
		                 SLODWORD(nodeIndexa.position.x),
		                 elementSizeX,
		                 elementSizeY,
		                 0LL);
		      if ( result == -1 )
		        return HG::Rendering::Runtime::AtlasGuillotine::_AddSurfaceInner(
		                 this,
		                 SLODWORD(y),
		                 elementSizeX,
		                 elementSizeY,
		                 0LL);
		    }
		  }
		  return result;
		}
		
		private int _FindParentNode(int child) => default; // 0x0000000189B67B80-0x0000000189B67C44
		// Int32 _FindParentNode(Int32)
		int32_t HG::Rendering::Runtime::AtlasGuillotine::_FindParentNode(
		        AtlasGuillotine *this,
		        int32_t child,
		        MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *v5; // rdx
		  __int64 v6; // rcx
		  int32_t i; // ebx
		  List_1_HG_Rendering_Runtime_AtlasGuillotine_TextureLayoutNode_ *m_nodes; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  SpatialPortalManager_FQueuedPortalObstructedData v11; // [rsp+20h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2730, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2730, 0LL);
		    if ( !Patch )
		LABEL_12:
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_235(
		             (ILFixDynamicMethodWrapper_6 *)Patch,
		             (Object *)this,
		             (NaviDirection__Enum)child,
		             0LL);
		  }
		  else
		  {
		    for ( i = 0; ; ++i )
		    {
		      m_nodes = this->fields.m_nodes;
		      if ( !m_nodes )
		        goto LABEL_12;
		      if ( i >= m_nodes->fields._size )
		        break;
		      System::Collections::Generic::List<Beyond::Gameplay::Audio::SpatialPortalManager::FQueuedPortalObstructedData>::get_Item(
		        &v11,
		        (List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *)this->fields.m_nodes,
		        i,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode>::get_Item);
		      if ( LODWORD(v11.position.x) == child )
		        return i;
		      v5 = (List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *)this->fields.m_nodes;
		      if ( !v5 )
		        goto LABEL_12;
		      System::Collections::Generic::List<Beyond::Gameplay::Audio::SpatialPortalManager::FQueuedPortalObstructedData>::get_Item(
		        &v11,
		        v5,
		        i,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode>::get_Item);
		      if ( LODWORD(v11.position.y) == child )
		        return i;
		    }
		    return -1;
		  }
		}
		
		private void _RemoveChildren(int nodeIndex) {} // 0x0000000189B67CFC-0x0000000189B6803C
		// Void _RemoveChildren(Int32)
		void HG::Rendering::Runtime::AtlasGuillotine::_RemoveChildren(
		        AtlasGuillotine *this,
		        int32_t nodeIndex,
		        MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *v5; // rcx
		  unsigned __int64 m_nodes; // rdx
		  float fadeTime; // esi
		  __int64 v8; // rdi
		  int32_t i; // esi
		  List_1_HG_Rendering_Runtime_AtlasGuillotine_TextureLayoutNode_ *v10; // rax
		  int v11; // edx
		  List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *v12; // rcx
		  float v13; // esi
		  float y; // edi
		  __m128d v15; // xmm0
		  int32_t j; // esi
		  List_1_HG_Rendering_Runtime_AtlasGuillotine_TextureLayoutNode_ *v17; // rax
		  int v18; // edx
		  List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *v19; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v21; // [rsp+20h] [rbp-60h]
		  __int128 v22; // [rsp+20h] [rbp-60h]
		  __int128 v23; // [rsp+20h] [rbp-60h]
		  __int128 v24; // [rsp+40h] [rbp-40h]
		  SpatialPortalManager_FQueuedPortalObstructedData nodeIndexa; // [rsp+60h] [rbp-20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2732, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2732, 0LL);
		    if ( !Patch )
		      goto LABEL_35;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, nodeIndex, 0LL);
		  }
		  else
		  {
		    m_nodes = (unsigned __int64)this->fields.m_nodes;
		    if ( !m_nodes )
		      goto LABEL_35;
		    System::Collections::Generic::List<Beyond::Gameplay::Audio::SpatialPortalManager::FQueuedPortalObstructedData>::get_Item(
		      &nodeIndexa,
		      (List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *)m_nodes,
		      nodeIndex,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode>::get_Item);
		    fadeTime = nodeIndexa.fadeTime;
		    v8 = *(_QWORD *)&nodeIndexa.position.x;
		    v24 = *(_OWORD *)&nodeIndexa.position.x;
		    if ( LODWORD(nodeIndexa.position.x) != -1 )
		      HG::Rendering::Runtime::AtlasGuillotine::_RemoveChildren(this, SLODWORD(nodeIndexa.position.x), 0LL);
		    if ( HIDWORD(v8) != -1 )
		      HG::Rendering::Runtime::AtlasGuillotine::_RemoveChildren(this, SHIDWORD(v8), 0LL);
		    if ( (_DWORD)v8 != -1 )
		    {
		      v5 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)this->fields.m_nodes;
		      if ( v5 )
		      {
		        System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::RemoveAt(
		          v5,
		          v8,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode>::RemoveAt);
		        v5 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)this->fields.m_nodes;
		        if ( v5 )
		        {
		          LODWORD(v21) = -1;
		          *((_QWORD *)&v21 + 1) = *((_QWORD *)&v24 + 1);
		          DWORD1(v21) = DWORD1(v24);
		          *(_OWORD *)&nodeIndexa.position.x = v21;
		          nodeIndexa.fadeTime = fadeTime;
		          System::Collections::Generic::List<Beyond::Gameplay::Audio::SpatialPortalManager::FQueuedPortalObstructedData>::set_Item(
		            (List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *)v5,
		            nodeIndex,
		            &nodeIndexa,
		            MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode>::set_Item);
		          for ( i = 0; ; ++i )
		          {
		            v10 = this->fields.m_nodes;
		            if ( !v10 )
		              break;
		            if ( i >= v10->fields._size )
		              goto LABEL_20;
		            System::Collections::Generic::List<Beyond::Gameplay::Audio::SpatialPortalManager::FQueuedPortalObstructedData>::get_Item(
		              &nodeIndexa,
		              (List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *)this->fields.m_nodes,
		              i,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode>::get_Item);
		            v11 = _mm_cvtsi128_si32(*(__m128i *)&nodeIndexa.position.x);
		            v22 = *(_OWORD *)&nodeIndexa.position.x;
		            if ( v11 < (int)v8 )
		            {
		              m_nodes = LODWORD(nodeIndexa.position.x);
		            }
		            else
		            {
		              m_nodes = (unsigned int)(v11 - 1);
		              LODWORD(v22) = m_nodes;
		            }
		            v5 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)v22;
		            if ( SLODWORD(nodeIndexa.position.y) >= (int)v8 )
		            {
		              DWORD1(v22) = LODWORD(nodeIndexa.position.y) - 1;
		              v5 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)v22;
		            }
		            if ( !this->fields.m_nodes )
		              break;
		            LODWORD(nodeIndexa.position.x) = m_nodes;
		            nodeIndexa.position.y = *((float *)&v5 + 1);
		            v12 = (List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *)this->fields.m_nodes;
		            *(_QWORD *)&nodeIndexa.position.z = *((_QWORD *)&v22 + 1);
		            System::Collections::Generic::List<Beyond::Gameplay::Audio::SpatialPortalManager::FQueuedPortalObstructedData>::set_Item(
		              v12,
		              i,
		              &nodeIndexa,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode>::set_Item);
		          }
		        }
		      }
		LABEL_35:
		      sub_1800D8260(v5, m_nodes);
		    }
		LABEL_20:
		    if ( DWORD1(v24) != -1 )
		    {
		      m_nodes = (unsigned __int64)this->fields.m_nodes;
		      if ( m_nodes )
		      {
		        System::Collections::Generic::List<Beyond::Gameplay::Audio::SpatialPortalManager::FQueuedPortalObstructedData>::get_Item(
		          &nodeIndexa,
		          (List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *)m_nodes,
		          nodeIndex,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode>::get_Item);
		        v5 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)this->fields.m_nodes;
		        v13 = nodeIndexa.fadeTime;
		        y = nodeIndexa.position.y;
		        if ( v5 )
		        {
		          System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::RemoveAt(
		            v5,
		            SLODWORD(nodeIndexa.position.y),
		            MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode>::RemoveAt);
		          v5 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)this->fields.m_nodes;
		          if ( v5 )
		          {
		            v15 = *(__m128d *)&nodeIndexa.position.x;
		            nodeIndexa.position.y = NAN;
		            LODWORD(nodeIndexa.position.x) = _mm_cvtsi128_si32((__m128i)v15);
		            *(_QWORD *)&nodeIndexa.position.z = *(_OWORD *)&_mm_unpackhi_pd(v15, v15);
		            nodeIndexa.fadeTime = v13;
		            System::Collections::Generic::List<Beyond::Gameplay::Audio::SpatialPortalManager::FQueuedPortalObstructedData>::set_Item(
		              (List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *)v5,
		              nodeIndex,
		              &nodeIndexa,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode>::set_Item);
		            for ( j = 0; ; ++j )
		            {
		              v17 = this->fields.m_nodes;
		              if ( !v17 )
		                break;
		              if ( j >= v17->fields._size )
		                return;
		              System::Collections::Generic::List<Beyond::Gameplay::Audio::SpatialPortalManager::FQueuedPortalObstructedData>::get_Item(
		                &nodeIndexa,
		                (List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *)this->fields.m_nodes,
		                j,
		                MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode>::get_Item);
		              v18 = _mm_cvtsi128_si32(*(__m128i *)&nodeIndexa.position.x);
		              v23 = *(_OWORD *)&nodeIndexa.position.x;
		              if ( v18 < SLODWORD(y) )
		              {
		                m_nodes = LODWORD(nodeIndexa.position.x);
		              }
		              else
		              {
		                m_nodes = (unsigned int)(v18 - 1);
		                LODWORD(v23) = m_nodes;
		              }
		              v5 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)v23;
		              if ( SLODWORD(nodeIndexa.position.y) >= SLODWORD(y) )
		              {
		                DWORD1(v23) = LODWORD(nodeIndexa.position.y) - 1;
		                v5 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)v23;
		              }
		              if ( !this->fields.m_nodes )
		                break;
		              LODWORD(nodeIndexa.position.x) = m_nodes;
		              nodeIndexa.position.y = *((float *)&v5 + 1);
		              v19 = (List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *)this->fields.m_nodes;
		              *(_QWORD *)&nodeIndexa.position.z = *((_QWORD *)&v23 + 1);
		              System::Collections::Generic::List<Beyond::Gameplay::Audio::SpatialPortalManager::FQueuedPortalObstructedData>::set_Item(
		                v19,
		                j,
		                &nodeIndexa,
		                MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::AtlasGuillotine::TextureLayoutNode>::set_Item);
		            }
		          }
		        }
		      }
		      goto LABEL_35;
		    }
		  }
		}
		
	}
}
