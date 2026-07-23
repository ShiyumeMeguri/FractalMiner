using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public struct ASMTile // TypeDefIndex: 37818
	{
		// Fields
		public Vector2 mins; // 0x00
		public Vector2 maxs; // 0x08
		public Vector3Int tileCoords; // 0x10
		public bool isValid; // 0x1C
		public bool isRendered; // 0x1D
		public bool isVisible; // 0x1E
		public int vtIndex; // 0x20
	
		// Properties
		public bool CanRender { get => default; } // 0x0000000189D156D4-0x0000000189D15730 
		// Boolean get_CanRender()
		bool HG::Rendering::Runtime::ASMTile::get_CanRender(ASMTile *this, MethodInfo *method)
		{
		  bool result; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  result = IFix::WrappersManagerImpl::IsPatched(2058, 0LL);
		  if ( result )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2058, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_828(Patch, this, 0LL);
		  }
		  else if ( this->isValid )
		  {
		    return !this->isRendered;
		  }
		  return result;
		}
		
		public static ASMTile InvalidTile { get; } // 0x0000000189D049BC-0x0000000189D04A08 
		// ASMTile get_InvalidTile()
		ASMTile *HG::Rendering::Runtime::ASMTile::get_InvalidTile(ASMTile *__return_ptr retstr, MethodInfo *method)
		{
		  struct ASMTile__Class *v2; // rax
		  ASMTile__StaticFields *static_fields; // rax
		  __int128 v5; // xmm0
		  __int128 v6; // xmm1
		
		  v2 = TypeInfo::HG::Rendering::Runtime::ASMTile;
		  if ( !TypeInfo::HG::Rendering::Runtime::ASMTile->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::ASMTile);
		    v2 = TypeInfo::HG::Rendering::Runtime::ASMTile;
		  }
		  static_fields = v2->static_fields;
		  v5 = *(_OWORD *)&static_fields->_InvalidTile_k__BackingField.mins.x;
		  v6 = *(_OWORD *)&static_fields->_InvalidTile_k__BackingField.tileCoords.m_X;
		  LODWORD(static_fields) = static_fields->_InvalidTile_k__BackingField.vtIndex;
		  *(_OWORD *)&retstr->mins.x = v5;
		  *(_OWORD *)&retstr->tileCoords.m_X = v6;
		  retstr->vtIndex = (int)static_fields;
		  return retstr;
		}
		
	
		// Constructors
		private ASMTile(Vector3Int tileCoords, Vector2 mins, Vector2 maxs, bool isValid, bool isRendered, bool isVisible, int vtIndex) : this() {
			this.mins = default;
			this.maxs = default;
			this.tileCoords = default;
			this.isValid = default;
			this.isRendered = default;
			this.isVisible = default;
			this.vtIndex = default;
		} // 0x0000000184DA22A0-0x0000000184DA22E0
		// ASMTile(Vector3Int, Vector2, Vector2, Boolean, Boolean, Boolean, Int32)
		void HG::Rendering::Runtime::ASMTile::ASMTile(
		        ASMTile *this,
		        Vector3Int *tileCoords,
		        Vector2 mins,
		        Vector2 maxs,
		        bool isValid,
		        bool isRendered,
		        bool isVisible,
		        int32_t vtIndex,
		        MethodInfo *method)
		{
		  int32_t m_Z; // eax
		
		  m_Z = tileCoords->m_Z;
		  *(_QWORD *)&this->tileCoords.m_X = *(_QWORD *)&tileCoords->m_X;
		  this->tileCoords.m_Z = m_Z;
		  this->isValid = isValid;
		  this->isRendered = isRendered;
		  this->isVisible = isVisible;
		  this->vtIndex = vtIndex;
		  this->mins = mins;
		  this->maxs = maxs;
		}
		
		public ASMTile(int coordX, int coordY, int refinementLevel, float gridSize) : this() {
			mins = default;
			maxs = default;
			tileCoords = default;
			isValid = default;
			isRendered = default;
			isVisible = default;
			vtIndex = default;
		} // 0x0000000189D15644-0x0000000189D156D4
		// ASMTile(Int32, Int32, Int32, Single)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::Runtime::ASMTile::ASMTile(
		        ASMTile *this,
		        int32_t coordX,
		        int32_t coordY,
		        int32_t refinementLevel,
		        float gridSize,
		        MethodInfo *method)
		{
		  __m128 v6; // xmm1
		  __m128 v7; // xmm0
		  Vector2 v8; // rax
		  __int64 v9; // r10
		
		  v6 = (__m128)COERCE_UNSIGNED_INT((float)coordY);
		  *(_QWORD *)&this->tileCoords.m_X = __PAIR64__(coordY, coordX);
		  v7 = (__m128)COERCE_UNSIGNED_INT((float)coordX);
		  this->tileCoords.m_Z = refinementLevel;
		  v6.m128_f32[0] = v6.m128_f32[0] * gridSize;
		  v7.m128_f32[0] = v7.m128_f32[0] * gridSize;
		  v6.m128_u64[0] = _mm_unpacklo_ps(v7, v6).m128_u64[0];
		  this->mins = (Vector2)v6.m128_u64[0];
		  v8 = sub_1853DF234(
		         *(Vector2 *)v6.m128_f32,
		         (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)LODWORD(gridSize), (__m128)LODWORD(gridSize)),
		         *(Vector2 *)&coordY,
		         *(Vector2 *)&refinementLevel);
		  *(_DWORD *)(v9 + 32) = -1;
		  *(Vector2 *)(v9 + 8) = v8;
		  *(_WORD *)(v9 + 28) = 1;
		  *(_BYTE *)(v9 + 30) = 0;
		}
		
		static ASMTile() {
	
		} // 0x0000000184DA2220-0x0000000184DA22A0
		// ASMTile()
		void HG::Rendering::Runtime::ASMTile::cctor(MethodInfo *method)
		{
		  Vector2__StaticFields *static_fields; // rax
		  __m128 v2; // xmm3
		  __m128 v3; // xmm3
		  ASMTile__StaticFields *v4; // rcx
		  __m128 v5; // xmm3
		  __int128 v6; // [rsp+10h] [rbp-28h]
		
		  static_fields = TypeInfo::UnityEngine::Vector2->static_fields;
		  v2 = _mm_shuffle_ps(
		         (__m128)LODWORD(static_fields->positiveInfinityVector.x),
		         (__m128)LODWORD(static_fields->positiveInfinityVector.x),
		         225);
		  v2.m128_f32[0] = static_fields->positiveInfinityVector.y;
		  *((_QWORD *)&v6 + 1) = 0x7FFFFFFFLL;
		  v3 = _mm_shuffle_ps(v2, v2, 198);
		  v4 = TypeInfo::HG::Rendering::Runtime::ASMTile->static_fields;
		  v3.m128_f32[0] = static_fields->negativeInfinityVector.x;
		  v5 = _mm_shuffle_ps(v3, v3, 39);
		  v5.m128_f32[0] = static_fields->negativeInfinityVector.y;
		  *(_QWORD *)&v6 = 0x7FFFFFFF7FFFFFFFLL;
		  *(__m128 *)&v4->_InvalidTile_k__BackingField.mins.x = _mm_shuffle_ps(v5, v5, 57);
		  *(_OWORD *)&v4->_InvalidTile_k__BackingField.tileCoords.m_X = v6;
		  v4->_InvalidTile_k__BackingField.vtIndex = -1;
		}
		
	}
}
