using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 44)]
	public struct ASMTile
	{
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool CanRender
		{
			get
			{
				// // Boolean get_CanRender()
				// bool HG::Rendering::Runtime::ASMTile::get_CanRender(ASMTile *this, MethodInfo *method)
				// {
				//   return this.isValid && !this.isRendered;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x0600092A RID: 2346 RVA: 0x000025D2 File Offset: 0x000007D2
		public static ASMTile InvalidTile
		{
			[CompilerGenerated]
			get
			{
				// // ASMTile get_InvalidTile()
				// ASMTile *HG::Rendering::Runtime::ASMTile::get_InvalidTile(ASMTile *__return_ptr retstr, MethodInfo *method)
				// {
				//   ASMTile__StaticFields *static_fields; // rax
				//   __int128 v4; // xmm0
				//   __int128 v5; // xmm1
				// 
				//   if ( !byte_18D919E56 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ASMTile);
				//     byte_18D919E56 = 1;
				//   }
				//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::ASMTile);
				//   static_fields = TypeInfo::HG::Rendering::Runtime::ASMTile.static_fields;
				//   v4 = *(_OWORD *)&static_fields._InvalidTile_k__BackingField.mins.x;
				//   v5 = *(_OWORD *)&static_fields._InvalidTile_k__BackingField.tileCoords.m_X;
				//   LODWORD(static_fields) = static_fields._InvalidTile_k__BackingField.vtIndex;
				//   *(_OWORD *)&retstr.mins.x = v4;
				//   *(_OWORD *)&retstr.tileCoords.m_X = v5;
				//   retstr.vtIndex = (int)static_fields;
				//   return retstr;
				// }
				// 
				return null;
			}
		}

		private ASMTile(Vector3Int tileCoords, Vector2 mins, Vector2 maxs, bool isValid, bool isRendered, bool isVisible, int vtIndex)
		{
			// // ASMTile(Vector3Int, Vector2, Vector2, Boolean, Boolean, Boolean, Int32)
			// void HG::Rendering::Runtime::ASMTile::ASMTile(
			//         ASMTile *this,
			//         Vector3Int *tileCoords,
			//         Vector2 mins,
			//         Vector2 maxs,
			//         bool isValid,
			//         bool isRendered,
			//         bool isVisible,
			//         int32_t vtIndex,
			//         MethodInfo *method)
			// {
			//   int32_t m_Z; // eax
			// 
			//   m_Z = tileCoords.m_Z;
			//   *(_QWORD *)&this.tileCoords.m_X = *(_QWORD *)&tileCoords.m_X;
			//   this.tileCoords.m_Z = m_Z;
			//   this.isValid = isValid;
			//   this.isRendered = isRendered;
			//   this.isVisible = isVisible;
			//   this.vtIndex = vtIndex;
			//   this.mins = mins;
			//   this.maxs = maxs;
			// }
			// 
		}

		public ASMTile(int coordX, int coordY, int refinementLevel, float gridSize)
		{
			// // ASMTile(Int32, Int32, Int32, Single)
			// // local variable allocation has failed, the output may be wrong!
			// void HG::Rendering::Runtime::ASMTile::ASMTile(
			//         ASMTile *this,
			//         int32_t coordX,
			//         int32_t coordY,
			//         int32_t refinementLevel,
			//         float gridSize,
			//         MethodInfo *method)
			// {
			//   __m128 v6; // xmm1
			//   __m128 v7; // xmm0
			//   Vector2 v8; // rax
			//   __int64 v9; // r10
			// 
			//   v6 = (__m128)COERCE_UNSIGNED_INT((float)coordY);
			//   *(_QWORD *)&this.tileCoords.m_X = __PAIR64__(coordY, coordX);
			//   v7 = (__m128)COERCE_UNSIGNED_INT((float)coordX);
			//   this.tileCoords.m_Z = refinementLevel;
			//   v6.m128_f32[0] = v6.m128_f32[0] * gridSize;
			//   v7.m128_f32[0] = v7.m128_f32[0] * gridSize;
			//   v6.m128_u64[0] = _mm_unpacklo_ps(v7, v6).m128_u64[0];
			//   this.mins = (Vector2)v6.m128_u64[0];
			//   v8 = sub_1842BE4B8(
			//          *(Vector2 *)v6.m128_f32,
			//          (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)LODWORD(gridSize), (__m128)LODWORD(gridSize)),
			//          *(Vector2 *)&coordY,
			//          *(Vector2 *)&refinementLevel);
			//   *(_DWORD *)(v9 + 32) = -1;
			//   *(Vector2 *)(v9 + 8) = v8;
			//   *(_WORD *)(v9 + 28) = 1;
			//   *(_BYTE *)(v9 + 30) = 0;
			// }
			// 
		}

		public Vector2 mins;

		public Vector2 maxs;

		public Vector3Int tileCoords;

		public bool isValid;

		public bool isRendered;

		public bool isVisible;

		public int vtIndex;
	}
}
